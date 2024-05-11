using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundrosoftAssesment.Models
{
    [Table("Departments")]
    [Keyless]
    public class Departments
    {
       
        public int? DeptId { get; set; }
        public string? DeptName { get; set;}
    }
}
