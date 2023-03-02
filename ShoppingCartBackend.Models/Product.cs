using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBackend.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsImported { get; set; }
    }
}
