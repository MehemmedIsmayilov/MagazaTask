using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopdanSatis
{
    internal class Product
    {

        public int No;
        public string Name;
        public double Price;
        public Products Type;

        public Product(int no,string name,double price,Products type)
        {
            No = no;
            Name = name;
            Price = price;
            Type = type;
        }



   
    }
}
