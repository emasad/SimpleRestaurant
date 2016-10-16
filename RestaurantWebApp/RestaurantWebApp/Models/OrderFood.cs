using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebApp.Models
{
    public class OrderFood
    {
        public int Id { get; set; }

        public int CodeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Type { get; set; }

        public int FoodNameId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime SelectedDate { get; set; }

    }
}