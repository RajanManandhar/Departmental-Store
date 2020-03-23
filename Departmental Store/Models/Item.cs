using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public DateTime manufactureDate { get; set; }
        public DateTime expiryDate { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

    }
}
