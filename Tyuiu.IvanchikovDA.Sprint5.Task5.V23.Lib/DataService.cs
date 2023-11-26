using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                double MinRes = int.MaxValue;
                double Min = int.MaxValue;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);
                    if ((Convert.ToDouble(line) < Min) && (-8 <= temp && temp < 19.21))
                    {
                        Min = Convert.ToDouble(line);
                        MinRes = double.Parse(line);
                    }
                }
                return Math.Round(MinRes, 3);
            }
        }
    }
}
