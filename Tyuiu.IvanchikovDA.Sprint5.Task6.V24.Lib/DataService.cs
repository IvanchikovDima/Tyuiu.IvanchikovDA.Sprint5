using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] numbers = line.Split(' ');

                    foreach (string num in numbers)
                    {
                        if (Int32.TryParse(num, out int number) && number >= 10000 && number <= 99999)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
