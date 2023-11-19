using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint5.Task0.V9.Lib;
using System.IO;

namespace Tyuiu.LachuginAV.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.LachuginAV.Sprint5\Tyuiu.LachuginAV.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt"; 
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}