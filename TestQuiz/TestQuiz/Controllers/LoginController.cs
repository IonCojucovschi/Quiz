using DataLayes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestQuiz.DataContext;

namespace TestQuiz.Controllers
{
    public class LoginController : Controller
    {
        private ApplicationContext _applicationContext;
        public LoginController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
           List<User>users= _applicationContext.Users.Select(el=>el).ToList<User>();
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _applicationContext.Users.Add(user);
                _applicationContext.SaveChanges();
            }
            return View();
        }
    }
}
