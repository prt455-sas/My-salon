using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySalon_Master.Models
{
    [Table("TimeRange")]
    public class TimeRangeModel
    {
        [Key] public int Id { get; set; }
        public string Range { get; set; }
    }
}
