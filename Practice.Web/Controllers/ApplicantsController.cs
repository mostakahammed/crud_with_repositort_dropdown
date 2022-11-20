using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practice.DataAccess.Models;
using Practice.Service.Infrastructure;

namespace Practice.Web.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly IApplicantBLR _applicant;
        public ApplicantsController(IApplicantBLR applicant)
        {
            _applicant = applicant;
        }
        public IActionResult Index()
        {
            var applicants = _applicant.GetApplicants();
            return View(applicants);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var applicant = _applicant.GetApplicant(id);
            return View(applicant);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<string> gender = new List<string>() { "Male", "Female", "Others" };
            ViewBag.Gender = new SelectList(gender);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Applicant model)
        {
            if (ModelState.IsValid)
            {
                List<string> gender = new List<string>() { "Male", "Female", "Others" };
                ViewBag.Gender = new SelectList(gender);
                _applicant.InsertApplicant(model);
                _applicant.Save();
                return RedirectToAction("Index", "Applicants");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<string> gender = new List<string>() { "Male", "Female", "Others" };
            ViewBag.Gender = new SelectList(gender);
            var applicant = _applicant.GetApplicant(id);
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Edit(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                List<string> gender = new List<string>() { "Male", "Female", "Others" };
                ViewBag.Gender = new SelectList(gender);
                _applicant.UpdateApplicant(applicant);
                _applicant.Save();
                return RedirectToAction("Index", "Applicants");
            }
            else
            {
                return View(applicant);
            }
        }

        public IActionResult Delete(int id)
        {
            _applicant.DeleteApplicant(id);
            _applicant.Save();
            return RedirectToAction("Index");
        }
    }
}
