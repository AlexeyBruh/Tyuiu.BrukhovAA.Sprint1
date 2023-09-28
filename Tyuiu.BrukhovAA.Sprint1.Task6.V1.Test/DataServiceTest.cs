using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "1";
            string wait = "49";
            var res = ds.SymbolCode(x);
            Assert.AreEqual(wait, res);
        }
    }
}
