using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariableprac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "임영웅";
            product.price = 100;
        }

        //C#스타일
        Product product2 = new Product() { name = "고구마", price = 2100 };
        Product product3 = new Product() { name = "감자", price = 2100 };
        Product product4 = new Product() { name = "호박고구마", price = 2100 };

        Product product5 = new Product() { name = "달달고구마", price = 2100 };

    }
}
