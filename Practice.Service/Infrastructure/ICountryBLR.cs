using Practice.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service.Infrastructure
{
    public interface ICountryBLR
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(long id);
        void InsertCountry(Country applicant);
        void UpdateCountry(Country applicant);
        void DeleteCountry(long id);
        void Save();
    }
}
