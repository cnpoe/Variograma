using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interpolacion
{
    class Herramientas
    {
        /// <summary>
        /// Lee un archivo y recupera los datos de las posiciones y los datos necesarios para hacer
        /// los cálculos
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Dictionary<string, object></returns>
        public static Dictionary<string, object> getData(string fileName)
        {
            string[] columns;
            List<string> datas = new List<string>();
            string line;
            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
            int ncols;
            double[,] data;

            Dictionary<string, object> file = new Dictionary<string, object>();

            file["Title"] = (Regex.Replace(sr.ReadLine(), @"\t|\n|\r", ""));
            ncols = Int32.Parse(sr.ReadLine());
            columns = new string[ncols];

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = Regex.Replace(sr.ReadLine(), @"\t|\n|\r", "");
            }

            file["Columns"] = columns;

            while ((line = sr.ReadLine()) != null)
            {
                datas.Add(line);
            }

            data = new double[datas.Count, ncols];

            for (int i = 0; i < datas.Count; i++)
            {
                int j = 0;
                foreach (var num in datas[i].Split(' '))
                {
                    data[i, j++] = Double.Parse(num);
                }
            }
            file["Data"] = data;
            return file;
        }
    }
}
