using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;
using App.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AwardsController : Controller
    {
        private IAwardRepository repository;

        public AwardsController(IAwardRepository repository)
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
            var award = repository.GetById(id);
            if (award == null)
            {
                return RedirectToAction("AwardNotFound");
            }

            return View(award);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Award award)
        {
            repository.Add(award);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var award = repository.GetById(id);
            if (award == null)
            {
                return RedirectToAction("AwardNotFound");
            }

            repository.Delete(award);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Award awardUpdate)
        {
            var award = repository.GetById(awardUpdate.Id);

            if (award == null )
            {
                return RedirectToAction("AwardNotFound");
            }

            award.Title = awardUpdate.Title;
            award.Description = awardUpdate.Description;

            repository.Update(award);

            return RedirectToAction("Index");
        }

        public IActionResult AwardNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
