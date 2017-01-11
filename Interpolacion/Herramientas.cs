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
            List<List<double>> data = new List<List<double>>();

            Dictionary<string, object> file = new Dictionary<string, object>();

            file["Title"] = (Regex.Replace(sr.ReadLine(), @"\t|\n|\r", ""));
            ncols = Int32.Parse(sr.ReadLine());
            columns = new string[ncols];

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = Regex.Replace(sr.ReadLine(), @"\t|\n|\r", "");
                data.Add(new List<double>());
            }

            file["Columns"] = columns;

            while ((line = sr.ReadLine()) != null)
            {
                datas.Add(line);
            }

            for (int i = 0; i < datas.Count; i++)
            {
                var dts = datas[i].Split(' ');

                for (int j = 0; j < dts.Length; j++)
                {
                    data[j].Add(Double.Parse(dts[j]));
                }

            }
            file["Data"] = data;
            return file;
        }
    }
}
