using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Models
{
    public class Product
    {

        

            public int ProductId { get; set; }
            [Required]
            public string ProductName { get; set; }
            [Required]
            public int Price { get; set; }
            [Required]
            public DateTimeOffset ExpDate { get; set; }
            [Required]
            public int TPIN { get; set; }
            public int? TotalQuantity { get; set; }
            public int? RemainingQuantity { get; set; }
            public int? Sold { get; set; }

            internal static Task<string> ToListAsync()
            {
                throw new NotImplementedException();
            }
        }
    }

