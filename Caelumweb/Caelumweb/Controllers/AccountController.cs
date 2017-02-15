using Caelum.Infra.Dados;
using Caelumweb.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caelumweb.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Usuario> signInManager;
        private readonly UserManager<Usuario> userManager;

        public AccountController(SignInManager<Usuario> _signInManager, UserManager<Usuario> _userManager)
        {
            signInManager = _signInManager;
            userManager = _userManager;
        }
        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario() { UserName = registerViewModel.Username };
                var result = await userManager.CreateAsync(usuario, registerViewModel.Password);
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
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var usuario = new Usuario { UserName = loginViewModel.Username };
            var result = await signInManager.PasswordSignInAsync(usuario.UserName, loginViewModel.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "A tentativa de Login falhou");
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
