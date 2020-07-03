using _6ClicksTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6ClicksTest.Services
{
    public class GoodsService
    {
        public Dictionary<string, string> GetReceipt(List<Good> goods)
        {
            var receipt = goods.ToDictionary(g => $"{g.Quantity} {ImportedText(g)} {g.Name} at ${Math.Round(g.TotalPrice,2)}", v => $"{v.TotalBasePrice}");
            receipt.Add($"Total Cost Price(without Tax): ${goods.Sum(g => g.TotalBasePrice)}","Total Price");
            receipt.Add($"Total Tax: ${goods.Sum(g => g.TotalSalesTax)}","Total Tax");
            return receipt;

        }
        private string ImportedText(Good good)
        {
            return good.IsImported ? " Imported " : "";
        }
    }
}
