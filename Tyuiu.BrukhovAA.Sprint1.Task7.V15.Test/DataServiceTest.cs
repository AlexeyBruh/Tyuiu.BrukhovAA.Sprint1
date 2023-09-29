using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task7.V15.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = Math.Round(ds.Calculate(x), 3);
            double wait = Math.Round(0.538593, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
