using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataAccess.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantId{ get; set; }
        [Required, StringLength(50),Display(Name ="Applicant Name")]
        public string ApplicantName{ get; set; }
        [Required, StringLength(50), Display(Name = "Father's Name")]
        public string FatherName{ get; set; }
        [Required, StringLength(50), Display(Name = "Mother's Name")]
        public string MotherName{ get; set; }
        [Required, Display(Name = "Gender")]
        public string Gender{ get; set; }
        [Required, StringLength(200), Display(Name = "Address")]
        public string Address{ get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM, yyyy}")]
        [Display(Name ="Birth Date")]
        public DateTime DOB{ get; set; }
    }
}
