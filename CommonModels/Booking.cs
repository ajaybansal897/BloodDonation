using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonModels
{
    public class Booking
    {
        [Display(Name = "Reference Number")]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        public int User_id { get; set; }

        [Display(Name = "Center ID")]
        public int Center_id { get; set; }

        public DateTime Timing { get; set; }

        [Display(Name = "Center Address")]
        public string Center_Address { get; set; }

        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

    }
}
