using DataLayes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestQuiz.DataContext;

namespace TestQuiz.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext applicationContext;

        public AdminController(ApplicationContext _applicationContext)
        {
            applicationContext = _applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdrministrateUsers()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var model = applicationContext.Users.Select(el=>el).ToList();
            return Json(model);
        }
        [HttpPost]
        public void AddUser(User user)
        {
            if (true)
            {
                applicationContext.Users.Add(user);
                applicationContext.SaveChanges();
            }
        }
        [HttpDelete]
        public void DeleteUser(User user)
        {
            if (ModelState.IsValid)
            {
                applicationContext.Users.Remove(user);
                applicationContext.SaveChanges();
            }
        }

        [HttpPost]
        public void UpdateUser(User user)
        {
            if (ModelState.IsValid)
            {
                applicationContext.Users.Update(user);
                applicationContext.SaveChanges();
            }
        }
    }
}
