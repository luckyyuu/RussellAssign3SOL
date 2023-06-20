using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RussellAssign3.Data
{
    public class Form_info
    {
        [Required]
        [StringLength(12, MinimumLength = 5)]
        public string userid { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 7)]
        public string password { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s.\-']")]
        public string name { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$")]
        public string address { get; set; }

        [Required]
        public string country { get; set; }

        [Required]
        [MaxLength(5)]
        public int zipcode { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string sex { get; set; } 

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Must select a Language")]
        public bool lang { get; set; }


        public string about { get; set; }
    }
}
