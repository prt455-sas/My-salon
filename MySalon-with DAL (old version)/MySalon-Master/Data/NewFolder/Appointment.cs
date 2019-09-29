using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySalon_Master.Data.NewFolder
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
    }
}
