using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double y = ((2 * Math.Pow(x, 3)) + (0.5 * Math.Pow(x, 2)) - (3.5 * x) + 2);

            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;

        }
    }
}

