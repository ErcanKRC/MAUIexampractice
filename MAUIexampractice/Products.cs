using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIexampractice
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string IMG { get; set; }

        public Products(string Name, double Price, string IMG)
        {
            this.Name = Name;
            this.Price = Price;
            this.IMG = IMG;
        }

    }
}
