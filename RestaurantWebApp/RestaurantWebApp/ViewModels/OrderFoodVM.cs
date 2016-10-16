using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantWebApp.ViewModels
{
    public class OrderFoodVM
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public SelectList FoodOrderList { get; set; }

    }
}