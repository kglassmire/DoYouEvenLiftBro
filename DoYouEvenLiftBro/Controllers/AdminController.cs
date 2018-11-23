using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoYouEvenLiftBro.Models;
using DoYouEvenLiftBro.Utility;
using DoYouEvenLiftBro.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DoYouEvenLiftBro.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }
    }
}