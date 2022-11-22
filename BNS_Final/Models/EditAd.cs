using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BNS_Final.Models
{
    public class EditAd
    {

        public string id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Customer Address")]
        public string address { get; set; }
    }
}
