using Authentication_Identity_Area_Roles.Models;
using Authentication_Identity_Area_Roles.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Identity_Area_Roles.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Dependency Injection (Bağımlılık enjeksiyonu)
            _userManager = userManager;
            _roleManager = roleManager;
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
    }
}
