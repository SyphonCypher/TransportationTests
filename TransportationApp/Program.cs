using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace TransportationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck ford = new Truck();
            Console.WriteLine(ford.GetMPH(65));

            Cycle bmw = new Cycle();
            Console.WriteLine(bmw.GetMPH(200));
        }
    }
}
