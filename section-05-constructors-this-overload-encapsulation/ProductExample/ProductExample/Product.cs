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
        private double _price;
        private int _quantity;

        public Product()
        {
            _quantity = 10;
        }

        public Product(string name, double price) : this()
        {
            _name = name;
            _price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            _quantity = quantity;
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

        public double Price
        {
            get { return _price; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public double TotalValueInStock()
        {
            return _price * _quantity;
        }
        public void AddProducts(int quantidade)
        {
            _quantity += quantidade;
        }
        public void RemoveProducts(int quantidade)
        {
            _quantity -= quantidade;
        }
        public override string ToString()
        {
            return _name
            + ", $ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantity
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
