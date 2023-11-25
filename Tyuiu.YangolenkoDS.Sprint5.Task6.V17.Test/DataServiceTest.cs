using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.YangolenkoDS.Sprint5.Task6.V17.Lib;

namespace Tyuiu.YangolenkoDS.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            var res = ds.LoadFromDataFile(path); 
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
