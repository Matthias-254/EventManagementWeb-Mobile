using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementWebApp.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } // NickName

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime Deleted { get; set; } = DateTime.MaxValue;
    }

}
