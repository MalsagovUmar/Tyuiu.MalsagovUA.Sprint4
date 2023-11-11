using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint4.Task6.V6.Lib;
namespace Tyuiu.MalsagovUA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] res = ds.Calculate(names);
            string[] wait = new string[] { "Борис", "Ирина" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
