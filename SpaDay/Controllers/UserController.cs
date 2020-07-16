using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string repeatPassword)
        {
            if (newUser.Password == repeatPassword)
            {
                //store new user
                ViewBag.person = newUser;
            }
            else
            {
                //pwds do not match
            }
            return Redirect("/User/index");
        }
    }
}
