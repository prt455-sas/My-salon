using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySalon_Master.Models.ViewModel
{
    public class ScheduleViewModel
    {
        public ScheduleViewModel()
        {
            UserEmail = new List<string>();
        }
        public string Id { get; set; }


        public List<string> UserEmail { get; set; }
     
    }
}
