using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autoloan.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        //[MaxLength(99)]
        //[MinLength(18)]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        //[MaxLength(10)]
        public int PhoneNumber { get; set; }

        [Required]
        //[EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string CarMake { get; set; }

        [Required]
        public int CarYear { get; set; }

        [Required]
        //[MaxLength(250000)]
        public int Carkilometer { get; set; }

        [Required]
        [StringLength(255)]
        public string CarModel { get; set; }

        [Required]
        public double DesiredLoanAmmount { get; set; }

        [Required]
        public double MonthlyIncome { get; set; }

        
        public DateTime DateTime { get; set; }

        [Required]
        public CarInsurance CarInsurance { get; set; }
    }
}