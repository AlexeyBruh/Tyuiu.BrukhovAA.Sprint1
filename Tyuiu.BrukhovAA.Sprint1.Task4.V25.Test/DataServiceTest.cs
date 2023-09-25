using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 30;
            double wait = Math.Round(0.866362, 3);
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
