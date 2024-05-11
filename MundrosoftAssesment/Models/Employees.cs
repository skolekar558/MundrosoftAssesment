using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MundrosoftAssesment.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
       
        public string? Email { get; set; }
        [Required(ErrorMessage = "Salary is required")]
       
        public long? Salary { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string? City { get; set; }
       
       
       




    }
}
