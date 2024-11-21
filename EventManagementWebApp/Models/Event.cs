using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementWebApp.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Started")]
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Display(Name = "Will end")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.MaxValue;

        [ForeignKey("Location")]
        public int LocationId { get; set; } = 1;

        public DateTime Deleted { get; set; } = DateTime.MaxValue;

        public Location? Location { get; set; }
    }
}
