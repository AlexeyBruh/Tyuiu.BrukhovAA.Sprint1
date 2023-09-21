using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 20;
            double v2 = 30;
            double S = 50;
            double T = 2;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            double wait = 150;
            Assert.AreEqual(wait, res);
        }
    }
}
