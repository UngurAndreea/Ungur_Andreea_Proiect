using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ungur_Andreea_Proiect.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }
       
    }
}
