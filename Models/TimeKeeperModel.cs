using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class TimeKeeperModel
    {
        [Range (0, 23, ErrorMessage = "Your hours must be between 0 and 23")]
        public int MondayStartHour { get; set; }

        [Range(0, 59, ErrorMessage = "Your minutes must be between 0 and 59")]
        public int MondayStartMinute { get; set; }

    }
}
