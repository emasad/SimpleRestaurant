using System.Collections.Generic;

namespace RestaurantWebApp.Models
{
    public class MemberType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<User> Users { get; set; } 
    }
}