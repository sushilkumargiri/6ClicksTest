using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6ClicksTest.Models
{
    public class Good
    {
        public string Name { get; set; }
        /// <summary>
        /// make it virtual in parent class so that it can be overriden to 0% in child classes (if required)
        /// Also, set default value to 10%
        /// </summary>
        public virtual double SalesTaxPercentage { get; set; } = 10;
        public bool IsImported { get; set; }
        public double ImportTaxPercentage { get; set; } = 5;
        public int Quantity { get; set; }
        public double BasePricePerUnit { get; set; }

        public double TotalBasePrice
        {
            get => Quantity * BasePricePerUnit;
            set => TotalBasePrice = value;
        }
        public double TotalSalesTax
        {
            get => Quantity * SalesTaxPercentage + (IsImported ? Quantity * ImportTaxPercentage : 0);
            set => TotalSalesTax = value;
        }
        public double TotalPrice
        {
            get => TotalBasePrice + TotalSalesTax;
            set => TotalPrice = value;
        }

    }
}
