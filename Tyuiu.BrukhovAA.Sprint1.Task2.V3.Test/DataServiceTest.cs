using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 3;
            var res = ds.ConvertHourToMin(a);
            Assert.AreEqual(180, res);
        }
    }
}
