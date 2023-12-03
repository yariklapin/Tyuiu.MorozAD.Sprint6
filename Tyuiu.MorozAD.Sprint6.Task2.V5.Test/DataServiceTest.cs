using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint6.Task2.V5.Lib;
namespace Tyuiu.MorozAD.Sprint6.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -32.26;
            valueWaitArray[1] = -27.50;
            valueWaitArray[2] = -22.80;
            valueWaitArray[3] = -17.95;
            valueWaitArray[4] = -12.97;
            valueWaitArray[5] = -9;
            valueWaitArray[6] = -0.31;
            valueWaitArray[7] = 3.77;
            valueWaitArray[8] = 8.57;
            valueWaitArray[9] = 13.42;
            valueWaitArray[10] = 18.28;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
