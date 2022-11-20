using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataAccess.Models
{
    [Table("Countries")]
    public class Country
    {
        [Display(Name = "Country Id")]
        [Required(ErrorMessage = "{0} is Required")]
        [Key]
        public Int64 CountryId { get; set; }

        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "{0} is Required")]
        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        public string CountryName { get; set; }
    }
}
