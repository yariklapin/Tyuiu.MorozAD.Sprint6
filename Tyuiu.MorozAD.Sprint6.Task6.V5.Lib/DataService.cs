using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.MorozAD.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (mas[i].Contains("i") || mas[i].Contains("I"))
                        {
                            resStr += mas[i] + " ";
                        }
                    }

                }
            }
            return resStr.Trim();
        }
    }
}
