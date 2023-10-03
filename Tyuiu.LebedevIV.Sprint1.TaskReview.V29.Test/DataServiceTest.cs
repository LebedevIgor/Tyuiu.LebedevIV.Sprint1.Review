using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.TaskReview.V29.Lib;

namespace Tyuiu.LebedevIV.Sprint1.TaskReview.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(1.41, res);
        }
    }
}
