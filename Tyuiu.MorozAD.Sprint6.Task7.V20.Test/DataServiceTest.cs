using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MorozAD.Sprint6.Task7.V20.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Артём\source\repos\Tyuiu.MorozAD.Sprint6\Tyuiu.MorozAD.Sprint6.Task7.V20\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
