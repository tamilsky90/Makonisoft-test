using Makonisoft.Facade;
using Makonisoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Makonisoft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonalInformationDTO personalInformationDTO)
        {
            if (ModelState.IsValid)
            {
                PersonalInformationFacade personalInformationFacade = new PersonalInformationFacade();
                personalInformationDTO = personalInformationFacade.SavePersonalInformation(personalInformationDTO);
                ViewBag.message = "Record(s) saved successfully.";
            }
            return View(personalInformationDTO);
        }
    }
}