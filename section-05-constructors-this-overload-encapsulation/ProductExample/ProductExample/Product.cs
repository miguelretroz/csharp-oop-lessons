using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductExample
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product()
        {
            Quantity = 10;
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double TotalValueInStock()
        {
            return Price * Quantity;
        }
        public void AddProducts(int quantidade)
        {
            Quantity += quantidade;
        }
        public void RemoveProducts(int quantidade)
        {
            Quantity -= quantidade;
        }
        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
