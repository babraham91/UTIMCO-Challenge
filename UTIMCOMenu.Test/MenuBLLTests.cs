using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using UTIMCOMenu.BLL;
using UTIMCOMenu.Models;

namespace UTIMCOMenu.Test
{
    [TestClass]
    public class MenuBLLTests
    {

        ItemModel item1 = new ItemModel { id = 3, label = "three" };
        ItemModel item2 = new ItemModel { id = 6, label = "six" };
        ItemModel item3 = new ItemModel { id = 9, label = "nine" };

        [TestMethod]
        public void Calculate_Successful()
        {
            // assemble
            var service = new MenuBLL();
            MenuModel menu = new MenuModel { items = new List<ItemModel> { item1,item2,item3} };
            List<MenuJson> input = new List<MenuJson> { new MenuJson { menu = menu} };
            SumsModel expected = new SumsModel { sums = new List<int> { 18 } };
            SumsModel actual = new SumsModel { };

            //act
            actual = service.Calculate(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
