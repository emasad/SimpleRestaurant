using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantWebApp.ViewModels
{
    public class ReportVM
    {
        public int Id { get; set; }
        public int CodeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }

        public DateTime PickDate { get; set; }

    }
}