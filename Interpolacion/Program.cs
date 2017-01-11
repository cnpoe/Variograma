using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> data = (List<List<double>>) Herramientas.getData("ZoneA.dat")["Data"];
            List<List<double>> P = new List<List<double>>();


            P.Add(data[0]);
            P.Add(data[1]);
            P.Add(data[3]);


            System.Console.WriteLine("Hi");
        }
    }
}
