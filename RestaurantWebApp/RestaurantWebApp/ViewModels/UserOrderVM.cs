using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantWebApp.ViewModels
{
    public class UserOrderVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public SelectList UserOrderList { get; set; }
    }
}