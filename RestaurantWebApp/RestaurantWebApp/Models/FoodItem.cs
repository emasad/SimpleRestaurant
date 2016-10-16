using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebApp.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public double UnitPrice { get; set; }
        
    }
}