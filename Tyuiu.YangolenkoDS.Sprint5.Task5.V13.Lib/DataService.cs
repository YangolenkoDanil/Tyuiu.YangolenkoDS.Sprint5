using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.Threading;

namespace Tyuiu.YangolenkoDS.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;

            using (StreamReader reader  = new StreamReader(path))
            {
                string line;
                while ((Convert.ToDouble(line = reader.ReadLine()) != 0) && (Convert.ToDouble(line = reader.ReadLine()) >= -1.5 && (Convert.ToDouble(line = reader.ReadLine()) <= 1.5)))
                {
                    res = res + Convert.ToDouble(line);
                    count++;
                }
                res = res / count;
            }
            return Math.Round(res, 3);
        }
    }
}
