using System.ComponentModel.DataAnnotations;

namespace EventManagementWebApp.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime Deleted { get; set; } = DateTime.MaxValue;
    }
}
