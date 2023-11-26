using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint5.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
