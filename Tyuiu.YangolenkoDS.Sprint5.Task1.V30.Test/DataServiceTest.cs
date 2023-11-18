using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint5.Task1.V30.Lib;

using System.IO;
using System.Diagnostics;

namespace Tyuiu.YangolenkoDS.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\angol\source\repos\Tyuiu.YangolenkoDS.Sprint5\Tyuiu.YangolenkoDS.Sprint5.Task1.V30\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
