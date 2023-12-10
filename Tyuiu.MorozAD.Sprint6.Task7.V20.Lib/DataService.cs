using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.MorozAD.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(int[,] matrix)

        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V20.txt";
            string fileDta = File.ReadAllText(pathSaveFile);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (arrayValues[i, 2]>=1&& arrayValues[i, 2] <=20)
                    {
                        arrayValues[i, 2] = 111;
                    }
                }
            }
            return arrayValues;
        }
    }
}
