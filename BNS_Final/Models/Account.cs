using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BNS_Final.Models
{
    public class Account
    {
        [Key]
        
        public long accountNumber { get; set; }

        [DataType(DataType.Currency)]
        public float balance { get; set; }

        public string cardNum { get; set; }

        public float availableAmount { get; set; }

        public string type { get; set; }

        public string userID { get; set; }
    }
}
