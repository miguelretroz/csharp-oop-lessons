using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise02
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += GrossSalary * (percentage / 100);
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
