using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySalon_Master.Models
{
    public class Appointment
    {
        [Key] public int Id { get; set; }
        [Column("date")] [Required] public string BookedDate { get; set; }
        [Column("time")] public string BookedTime { get; set; }

        public string UserId { get; set; }

        public string BookTime { get; set; }
        public int TimeRangeID { get; set; }

       // public IEnumerable<TimeRangeModel> TimeRangeList { get; set; }

    }
}