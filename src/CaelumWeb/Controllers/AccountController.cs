using CaelumWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Usuario> signInManager;
        private readonly UserManager<Usuario> userManager;

        public AccountController(UserManager<Usuario> _userManager, SignInManager<Usuario> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public IActionResult Register() => View();

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario { UserName = model.Username };
                var result = await userManager.CreateAsync(usuario, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(usuario, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View();
        }
    }
}
