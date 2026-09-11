using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Project_1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "This Name is Too Long")]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; }
        public string ? Address { get; set; }

        [Required]
        [Range(3000, 10000, ErrorMessage = "Salary must be between 3000 and 10000.")]
        public double Salary { get; set; }

    }
}
