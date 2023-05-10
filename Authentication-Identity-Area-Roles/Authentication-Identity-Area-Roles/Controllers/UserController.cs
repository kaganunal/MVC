using Authentication_Identity_Area_Roles.Models;
using Authentication_Identity_Area_Roles.Models.Authentication.SignIn;
using Authentication_Identity_Area_Roles.Models.Authentication.SignUp;
using KaganUnal.Management.Service.Models;
using KaganUnal.Management.Service.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authentication_Identity_Area_Roles.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        {
            //Dependency Injection (Bağımlılık enjeksiyonu)
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();
        }

        //From Form kısmı defaultta FromQuery'dir.
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] SignUpAppUser appUser, string role = "USER")
        {
            //Kayıt olabilmesi için benzersiz bir username ve email bilgisi olması gerekir!
            //Username
            //Email
            IActionResult viewResult = null;

            var userByName = await _userManager.FindByNameAsync(appUser.Username);
            var userByEmail = await _userManager.FindByEmailAsync(appUser.Email);

            if (userByName != null || userByEmail != null)
            {
                viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Bu kullanıcı adı veya email adresine sahip başka bir kullanıcı sistemde bulunmaktadır!" });
            }
            else
            {
                var userRole = await _roleManager.FindByNameAsync(role);
                if (userRole != null)
                {
                    IdentityUser eklenecekKullanici = new()
                    {
                        UserName = appUser.Username,
                        Email = appUser.Email,
                        SecurityStamp = Guid.NewGuid().ToString()
                    };

                    var eklemeSonucu = await _userManager.CreateAsync(eklenecekKullanici, appUser.Password);

                    if (eklemeSonucu.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(eklenecekKullanici, role);

                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(eklenecekKullanici);
                        var emailDogrulamaLinki = Url.Action(nameof(++++++, ConfirmEmail), "User", new { token, email = eklenecekKullanici.Email }, Request.Scheme);
                        var emailDogrulamaMesaji = new MailMessage(new Dictionary<string, string>() { { eklenecekKullanici.UserName!, eklenecekKullanici.Email! } }, "Email Doğrulama Linki", $"<b>Uygulamamıza giriş yapabilmeniz için doğrulama linki:<b/> <a href=\"{emailDogrulamaLinki}\"><button>Onayla</button></a>)");

                        _emailService.SendEmail(emailDogrulamaMesaji);

                        viewResult = RedirectToAction("Index");
                    }
                    else
                    {
                        viewResult = StatusCode(StatusCodes.Status500InternalServerError, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Kullanıcı sisteme kayıt edilirken sunucuda hata oluştu!" });
                    }
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Uygulamada böyle bir kullanıcı rolü bulunmamaktadır" });
                }

            }
            return viewResult;

        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromForm] SignInAppUser appUser)
        {
            IActionResult viewResult;

            var userByName = await _userManager.FindByNameAsync(appUser.Username);


            if (userByName != null)
            {
                if (await _userManager.CheckPasswordAsync(userByName, appUser.Password))
                {
                    var payload = new List<Claim>
                    {
                        new Claim ("username", appUser.Username),
                        new Claim("tokenID",Guid.NewGuid().ToString())
                    };

                    var jwtToken = GetToken(payload, 4, 15);
                    var tokenStr = new JwtSecurityTokenHandler().WriteToken(jwtToken);

                    viewResult = Ok(new { token = tokenStr, expires = jwtToken.ValidTo });
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "Kullanıcı Girişi Hatası", Message = "Sistemde böyle bir kullanıcı bulunmamaktadır!" });
                }
            }
            else
            {
                viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "Parola Hatası", Message = "Girilen parola hatalıdır!" });
            }

            return viewResult;
        }

        private JwtSecurityToken GetToken(List<Claim> payload, int hours, int minutes)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT")["Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims: payload,
                //notBefore: DateTime.UtcNow.AddMinutes(5),//5 dk sonra token aktif olacaktır!
                //Belirlenen süre sonunda token geçersiz olacaktır!
                expires: DateTime.UtcNow.AddHours(hours).AddMinutes(minutes),
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)

                );

            return token;
        }

        public IActionResult SendMail()
        {
            var emailMessage = new MailMessage(new Dictionary<string, string>() { { "Fatih Kaan Açıkgöz 1", "fatihkaanacikgoz@gmail.com" }, { "Fatih Kaan Açıkgöz 2", "fatihimin3406@gmail.com" } }, "İlk mail denemesi başlığı", "<h1>Mantığının anlaşılması gereken hadiseler</h1><ol><li>OOP Mantığı</li><li>SOLID prensipleri</li></ol><p>Yazan: <b>Fatih Kaan Açıkgöz</b></p>");

            _emailService.SendEmail(emailMessage);

            return StatusCode(StatusCodes.Status200OK, new AppResponse() { Status = "Başarılı", Message = "Email başarıyla gönderildi!" });
        }

        //public async Task<>
    }
}
