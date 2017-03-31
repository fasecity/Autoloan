using Autoloan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autoloan.ViewModels
{
    public class ApplicantFormViewModel
    {
       // public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$")]
        public string LastName { get; set; }

        [Required]
        //[MaxLength(3)]
        [Range(18, 100,
        ErrorMessage = "Value for {0} must be over {1} .")]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        //[MaxLength(10)]
        //[MinLength(10)]
        [RegularExpression(@"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}")]
        public double PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string CarMake { get; set; }

        [Required]
        [Range(2010, 2050,
        ErrorMessage = "Value for {0} must be over {1} .")]
        public int CarYear { get; set; }

        [Required]
        [Range(1, 250000,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double Carkilometer { get; set; }

        [Required]
        [StringLength(255)]
        public string CarModel { get; set; }

        [Required]
        public double DesiredLoanAmmount { get; set; }

        [Required]
        public double MonthlyIncome { get; set; }


        public DateTime DateTime { get; set; }

        [Required]
        //genreId as stored in Db
        public int CarInsurance { get; set; }
        public IEnumerable<CarInsurance> CarInsurances { get; set; }
    }
}