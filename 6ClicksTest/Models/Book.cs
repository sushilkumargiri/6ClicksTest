using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6ClicksTest.Models
{
    public class Book : Good
    {
        /// <summary>
        /// override sales tax to 0%
        /// </summary>
        public override double SalesTaxPercentage { get; set; } = 0;
    }
}
