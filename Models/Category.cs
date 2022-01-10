using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ungur_Andreea_Proiect.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
