using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoYouEvenLiftBro.Models;
using DoYouEvenLiftBro.Utility;
using DoYouEvenLiftBro.DAL;
using DoYouEvenLiftBro.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DoYouEvenLiftBro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly DoYouEvenLiftBroContext _context;

        public AuthController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            DoYouEvenLiftBroContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.UserName, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    Log.Information("User created a new account with password");
                    //var callbackUrl = Url.EmailConfirmationLink(user.Id.ToString(), code, Request.Scheme);
                    //await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    Log.Information("User created a new account with password.");
                    return Ok("Registered successfully");
                }                                
            }

            return BadRequest(ModelState.Errors());
        }

        /// <summary>
        /// Authenticate and login user.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="returnUrl"></param>
        /// <response code="200">Successful login.</response>
        /// <response code="400">Two-factor not set up yet.</response>
        /// <response code="401">Authentication failed.</response>
        /// <response code="403">Account locked out.</response>
        /// <response code="404">Invalid model.</response>
        /// <returns></returns>
        [HttpPost("login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Login([FromBody]LoginVM model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return Ok("Logged in");
                }
                if (result.RequiresTwoFactor)
                {
                    ModelState.AddModelError("result", "Requires 2fa");
                    return NotFound(ModelState.Errors());
                    // return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("result", "Locked out");
                    return Forbid();
                }

                return Unauthorized();
            }

            return BadRequest(ModelState.Errors());
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok("Logged out");
        }
    }
}