using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint4.Task3.V9.Lib;
namespace Tyuiu.MalsagovUA.Sprint4.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 9, 6, 4, 5, 3 },
                                           { 7, 4, 7, 5, 3 },
                                           { 8, 5, 9, 9, 3 },
                                           { 7, 8, 7, 9, 3 },
                                           { 3, 7, 3, 7, 7 } };
            int res = ds.Calculate(array);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
