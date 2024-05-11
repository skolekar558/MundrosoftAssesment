using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundrosoftAssesment.Models
{
    [Table("Roles")]
    [Keyless]
    public class Roles
    {
        public int RId { get; set; }
        public string? RoleName { get; set; }
    }
}