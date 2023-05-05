using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } = default!;
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string City { get; set; } = default!;
        [Required]
        public string State { get; set; } = default!;
        [Required]
        public decimal Salary { get; set; } = default!;
    }
}
