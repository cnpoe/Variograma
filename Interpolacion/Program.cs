using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;

namespace Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> data = (List<List<double>>)Herramientas.getData("ZoneA.dat")["Data"];
            List<List<double>> P = new List<List<double>>();

            //List<int> pt = { 2000, 4700 };
            List<int> lags;
            int tolerance = 250;
            double sill;

            P.Add(data[0]);
            P.Add(data[1]);
            P.Add(data[3]);

            lags = Herramientas.Arange(tolerance, 10000, tolerance * 2);

            sill = Statistics.Variance(P[2]);


            System.Console.WriteLine("Hi");
        }
    }
}
