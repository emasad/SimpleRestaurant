using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantWebApp.Models
{
    public class User
    {
        [Key]
        public int  Id { get; set; }




        [Required]
        [Index(IsUnique = true)]
        [MaxLength(8)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }
        [Required]
        [DisplayName("Type")]
        public int MemberTypeId { get; set; }

        public MemberType MemberType { get; set; }

    }
}