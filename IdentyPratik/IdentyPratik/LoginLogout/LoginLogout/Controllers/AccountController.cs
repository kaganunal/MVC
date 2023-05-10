using LoginLogout.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginLogout.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserVm userVm)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = userVm.UserName,
                    Email = userVm.Email
                };
                IdentityResult result = await _userManager.CreateAsync(appUser, userVm.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "ADMIN");
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public async Task<IActionResult> List()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var deletedUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (deletedUser is not null)
            {
                await _userManager.DeleteAsync(deletedUser);
            }

            return RedirectToAction("List");
        }

        public async Task<IActionResult> Update(string id)
        {

            var updatedUser = await _userManager.Users.FirstOrDefaultAsync(y => y.Id.Equals(id));
            UserUpdateDto user = new UserUpdateDto()
            {
                Id = updatedUser.Id,
                UserName = updatedUser.UserName,
                Email = updatedUser.Email,
                Password = updatedUser.PasswordHash
            };
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, UserUpdateDto userDto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(y => y.Id.Equals(id));
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                IdentityResult result = await _userManager.UpdateAsync(user);
                user.UserName = userDto.UserName;
                user.Email = userDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userDto.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("List");

            }

            return View(userDto);


        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginVm.UserName, loginVm.Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "App");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Geçersiz oturum açma denemesi");
                }
            }


            return View(loginVm);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }

    }

}

