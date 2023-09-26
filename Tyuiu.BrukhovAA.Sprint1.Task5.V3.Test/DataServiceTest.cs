using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 15435;
            int wait = 4;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
