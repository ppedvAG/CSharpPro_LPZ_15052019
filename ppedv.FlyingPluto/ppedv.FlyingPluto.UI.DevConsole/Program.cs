using ppedv.FlyingPluto.Logic;
using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.FlyingPluto.UI.DevConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("*** FlyingPluto v0.1 GOLD Edition ***");


            var ass = Assembly.LoadFile(@"C:\Users\ar2\source\repos\ppedvAG\CSharpPro_LPZ_15052019\ppedv.FlyingPluto\ppedv.FlyingPluto.Data.EFdotnet\bin\Debug\ppedv.FlyingPluto.Data.EFdotnet.dll");

            var uow = ass.GetTypes().Where(x => x.GetInterfaces().Contains(typeof(IUnitOfWork))).FirstOrDefault();
            var core = new Core((IUnitOfWork)Activator.CreateInstance(uow));

            int zahl = 6_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________6_______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________6;

            if (await Task.Run(() => core.UoW.GetRepository<Vermietung>().Query().Count() != 0))
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
