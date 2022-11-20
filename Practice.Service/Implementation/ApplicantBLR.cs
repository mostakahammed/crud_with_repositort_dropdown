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
    public class ApplicantBLR : IApplicantBLR
    {
        private readonly AppDbContext _context;
        public ApplicantBLR(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Applicant> GetApplicants()
        {
            List<Applicant> applicants = _context.Applicants.ToList();
            return applicants;
        }

        public Applicant GetApplicant(int id)
        {
            var applicant = _context.Applicants.Where(x => x.ApplicantId == id).FirstOrDefault();
            return applicant;
        }

        public void InsertApplicant(Applicant model)
        {
            if (model != null)
            {
                _context.Applicants.Add(model);
            }
        }

        public void UpdateApplicant(Applicant model)
        {
            if (model != null)
            {
                _context.Applicants.Update(model);
            }
        }

        public void DeleteApplicant(int id)
        {
            if (id != null)
            {
                Applicant applicant = _context.Applicants.Find(id);
                _context.Applicants.Remove(applicant);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
