using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantWebApp.Models;

namespace RestaurantWebApp.ViewModels
{
    public class TypeListVm
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ContactNo { get; set; }

        
        [Required]
        public int MemberTypeId { get; set; }

        public SelectList MemberTypes { get; set; }
        
    }
}