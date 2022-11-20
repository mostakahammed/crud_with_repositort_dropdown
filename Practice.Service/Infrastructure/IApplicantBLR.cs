using Practice.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service.Infrastructure
{
    public interface IApplicantBLR
    {
        IEnumerable<Applicant> GetApplicants();
        Applicant GetApplicant(int id);
        void InsertApplicant(Applicant applicant);
        void UpdateApplicant(Applicant applicant);
        void DeleteApplicant(int id);
        void Save();
    }
}
