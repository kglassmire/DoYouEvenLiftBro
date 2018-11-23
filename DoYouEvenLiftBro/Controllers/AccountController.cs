using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoYouEvenLiftBro.DAL.Entities;
using DoYouEvenLiftBro.Models;
using DoYouEvenLiftBro.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DoYouEvenLiftBro.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                model.Errors = ModelState.Errors();
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: true);
            if (result.Succeeded) // password correct
            {

                return RedirectToAction("Dashboard", "Admin");
            }

            if (result.RequiresTwoFactor) // requires 2fa
            {
                ModelState.AddModelError("result", "Requires 2fa");
                model.Errors = ModelState.Errors();
                return View(model);
                // return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
            }
            if (result.IsLockedOut) // locked out
            {
                ModelState.AddModelError("result", "Locked out");
                model.Errors = ModelState.Errors();
                return View(model);
            }

            ModelState.AddModelError("result", "Not authorized."); // wrong password
            model.Errors = ModelState.Errors();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                User createUser = new User { Email = model.Email, UserName = model.UserName };
                var result = await _userManager.CreateAsync(createUser, model.Password);

                if (result.Succeeded)
                {
                    RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.Code, item.Description);
                        model.Errors = ModelState.Errors();
                    }

                    return View(model);
                }
            }

            model.Errors = ModelState.Errors();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }


    }
}