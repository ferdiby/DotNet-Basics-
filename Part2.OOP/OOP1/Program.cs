using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitStock = 10;

            Product product1 = new Product() { Id= 2, ProductName= "Sandalye",UnitPrice = 350,UnitStock=23};

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            product1.ProductName = "Monitor";
            Console.WriteLine(product1.ProductName);
            productManager.Update(product1);


        }
    }
}
