using ppedv.FlyingPluto.Logic;
using ppedv.FlyingPluto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.FlyingPluto.UI.DevConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** FlyingPluto v0.1 GOLD Edition ***");

            var core = new Core();

            if (core.Repository.Query<Vermietung>().Count() == 0)
                core.CreateDemoData();

            foreach (var k in core.Repository.GetAll<Kunde>())
            {
                Console.WriteLine($"{k.Name} {k.GebDatum:d}");
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
