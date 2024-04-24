using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace TestCoreProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        [StringLength(30, ErrorMessage = "Invalid Location")]
        public string LocationPin { get; set; } = null!;

        [Required]
        public string HistoryJson { get; set; } = null!;

        [Required]
        public string[] Interests { get; set; } = null!;
    }
}
