using System.ComponentModel.DataAnnotations;

namespace Autoloan.Models
{
    public class CarInsurance
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}