using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RestaurantWebApp.Models;

namespace RestaurantWebApp.Context
{
    public class RestaurantContext:DbContext
    {
        public RestaurantContext() : base("RestaurantConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderFood> OrderFoods { get; set; }

    }
}