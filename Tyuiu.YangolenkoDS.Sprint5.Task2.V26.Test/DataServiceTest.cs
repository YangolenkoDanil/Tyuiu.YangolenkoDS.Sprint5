
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.YangolenkoDS.Sprint5.Task2.V26.Lib;

namespace Tyuiu.YangolenkoDS.Sprint5.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\angol\source\repos\Tyuiu.YangolenkoDS.Sprint5\Tyuiu.YangolenkoDS.Sprint5.Task2.V26\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
