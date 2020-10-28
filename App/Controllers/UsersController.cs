using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;
using App.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class UsersController : Controller
    {
        private IUserRepository repository;

        public UsersController(IUserRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IActionResult Index()
        {
            return View(repository.GetAll());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = repository.GetById(id);
            if (user == null)
            {
                return RedirectToAction("UserNotFound");
            }

            return View("Edit", user);
        }

        [HttpPost]
        public IActionResult Edit(User userUpdate)
        {
            var user = repository.GetById(userUpdate.Id);
            if (user == null)
            {
                return RedirectToAction("UserNotFound");
            }
            user.FirstName = userUpdate.FirstName;
            user.LastName = userUpdate.LastName;

            repository.Update(user);

            return RedirectToAction("Index");
        }

        public IActionResult UserNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

    }
}
