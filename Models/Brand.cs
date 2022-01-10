using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ungur_Andreea_Proiect.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
