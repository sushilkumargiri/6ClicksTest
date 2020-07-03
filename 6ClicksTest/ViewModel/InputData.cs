using _6ClicksTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6ClicksTest.ViewModel
{
    public class InputData
    {
        public static List<Good> GetGoodsInput()
        {

            Book book = new Book() { Quantity = 1, BasePricePerUnit = 12.49, Name = "Book" };
            Food food = new Food() { Quantity = 1, BasePricePerUnit = 0.85, Name = "Cholate Bar" };
            Good item = new Good() { Quantity = 1, BasePricePerUnit = 12.99, Name = "Music CD" };
            List<Good> goods = new List<Good>() { book, food, item };

            return goods;
        }
        public static List<Good> GetImportedGoodsInput()
        {

            Food food = new Food() { Quantity = 1, BasePricePerUnit = 12.49,IsImported=true, Name = "Box Of Chocolate" };
            Good good = new Good() { Quantity = 1, BasePricePerUnit = 0.85, IsImported=true, Name = "Bottle of Perfume" };
            List<Good> goods = new List<Good>() { food, good };

            return goods;
        }
    }
}
