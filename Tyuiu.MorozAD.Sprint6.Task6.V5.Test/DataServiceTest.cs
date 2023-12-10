using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint6.Task6.V5.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str =" ";
            string path = @"C:\DataSprint6\InPutFileTask6V5.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(str,path);
            string wait = "BYiySs brIBPtX KyiidnDo sMLuPzlvneiTo XIpph";
            Assert.AreEqual(wait, res);
        }
    }
}
