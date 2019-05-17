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

            if (core.UoW.GetRepository<Vermietung>().Query().Count() == 0)
                core.CreateDemoData();

            foreach (var vm in core.UoW.GetRepository<Vermietung>().Query().OrderBy(x => x.Von).ToList())
            {
                Console.WriteLine($"{vm.Kunde.Name}");
                Console.WriteLine($"{vm.Von:d}-{vm.Bis:d} {vm.Auto.Marke} {vm.Auto.Modell} {vm.Auto.Kennzeichen}");
                Console.WriteLine("--------------------------------------------------------------");
            }

            foreach (var k in core.Kunden.GetAllKundenDieSeitXXNichtMehrGebuchtHaben(10, DateTime.Now))
            {
                Console.WriteLine(k.Name);
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
