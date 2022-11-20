using Microsoft.AspNetCore.Mvc;
using Practice.DataAccess.Models;
using Practice.Service.Infrastructure;

namespace Practice.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountryBLR _country;
        public CountriesController(ICountryBLR country)
        {
            _country = country;
        }
        public IActionResult Index()
        {
            var countries = _country.GetCountries();
            return View(countries);
        }

        [HttpGet]
        public IActionResult Details(long id)
        {
            var country = _country.GetCountry(id);
            return View(country);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _country.InsertCountry(model);
                    _country.Save();
                    return RedirectToAction("Index", "Countries");
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var country = _country.GetCountry(id);
            return View(country);
        }
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _country.UpdateCountry(country);
                    _country.Save();
                    return RedirectToAction("Index", "Countries");
                }
                else
                {
                    return View(country);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Delete(long id)
        {
            _country.DeleteCountry(id);
            _country.Save();
            return RedirectToAction("Index");
        }
    }
}
