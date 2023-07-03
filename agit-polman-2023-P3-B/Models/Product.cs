using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agit_polman_2023_P3_B.Models
{
    //[Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
}
