using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint5.Task1.V26.Lib;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.IvanchikovDA.Sprint5\Tyuiu.IvanchikovDA.Sprint5.Task1.V26\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
