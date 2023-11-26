using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LachuginAV.Sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                Regex regex = new Regex("([А-Я])");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count += regex.Matches(line).Count;
                }



            }
            return count;
        }
    }
}