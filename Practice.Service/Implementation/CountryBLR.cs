using Practice.DataAccess.Context;
using Practice.DataAccess.Models;
using Practice.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service.Implementation
{
    public class CountryBLR : ICountryBLR
    {
        private readonly AppDbContext _context;
        public CountryBLR(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Country> GetCountries()
        {
            List<Country> countries = _context.Countries.ToList(); 
            return countries;
        }

        public Country GetCountry(long id)
        {
            var country = _context.Countries.Where(x => x.CountryId == id).FirstOrDefault();
            return country;
        }

        public void InsertCountry(Country model)
        {
            if (model != null)
            {
                _context.Countries.Add(model);
            }
        }

        public void UpdateCountry(Country model)
        {
            if (model != null)
            {
                _context.Countries.Update(model);
            }
        }

        public void DeleteCountry(long id)
        {
            if (id != null)
            {
                Country country = _context.Countries.Find(id);
                _context.Countries.Remove(country);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
