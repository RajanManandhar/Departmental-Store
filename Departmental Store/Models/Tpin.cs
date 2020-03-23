using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Models
{
    public class Tpin
    {
        [Key]
        public int id { get; set; }
        public int code { get; set; }
        public int customerId { get; set; }
    }
}
