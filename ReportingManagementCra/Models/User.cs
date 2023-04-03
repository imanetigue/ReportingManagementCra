using System.ComponentModel.DataAnnotations;

namespace ReportingManagementCra.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BirthDate{ get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
