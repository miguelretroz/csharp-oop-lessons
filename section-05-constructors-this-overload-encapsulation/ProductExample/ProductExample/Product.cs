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
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product()
        {
            Quantity = 10;
        }

        public Product(string name, double price) : this()
        {
            _name = name;
            Price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                    _name = value;
            }
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
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
