﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.YangolenkoDS.Sprint5.Task7.V3.Lib;

namespace Tyuiu.YangolenkoDS.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\angol\source\repos\Tyuiu.YangolenkoDS.Sprint5\Tyuiu.YangolenkoDS.Sprint5.Task7.V3\bin\Debug\OutPutDataFileTask7V3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
