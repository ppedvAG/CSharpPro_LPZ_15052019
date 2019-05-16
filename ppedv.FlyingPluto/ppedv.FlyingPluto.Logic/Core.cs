using Bogus;
using ppedv.FlyingPluto.Data.EF;
using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Linq;

namespace ppedv.FlyingPluto.Logic
{
    public class Core
    {
        public IRepository Repository { get; private set; }

        public Core(IRepository repo) //todo: DP Injection in here
        {
            Repository = repo;
        }
        public Core() : this(new Data.EF.EfRepository())
        { }

        public void CreateDemoData()
        {

            var kundenFaker = new Faker<Kunde>()
                                .RuleFor(x => x.Name, x => x.Name.FullName())
                                .RuleFor(x => x.GebDatum, x => x.Date.Past(40));

            var k1 = kundenFaker.Generate();
            var k2 = kundenFaker.Generate();
            var k3 = kundenFaker.Generate();

            var standortFaker = new Faker<Standort>()
                                    .RuleFor(x => x.Name, x => x.Address.City())
                                    .RuleFor(x => x.Chef, x => x.Name.FullName());

            var s1 = standortFaker.Generate();
            var s2 = standortFaker.Generate();

            var autoFaker = new Faker<Auto>()
                                  .RuleFor(x => x.Farbe, x => x.Commerce.Color())
                                  .RuleFor(x => x.Sizte, x => x.Random.Even(2, 12))
                                  .RuleFor(x => x.Automatik, x => x.Random.Bool())
                                  .RuleFor(x => x.Kennzeichen, x => $"{x.Lorem.Letter(2)}-{x.Lorem.Letter(2)} {x.Random.Number(1, 9999)}")
                                  .RuleFor(x => x.Marke, x => x.Vehicle.Manufacturer())
                                  .RuleFor(x => x.Modell, x => x.Vehicle.Model());

            var a1 = autoFaker.Generate();
            var a2 = autoFaker.Generate();
            var a3 = autoFaker.Generate();

            var vm1 = new Vermietung() { AbholStandort = s1, ZielStandort = s2, Auto = a1, Kunde = k1, Km = 100, Von = DateTime.Now.AddDays(-15), Bis = DateTime.Now.AddDays(-11) };
            var vm2 = new Vermietung() { AbholStandort = s1, ZielStandort = s1, Auto = a2, Kunde = k2, Km = 11, Von = DateTime.Now.AddDays(-95), Bis = DateTime.Now.AddDays(-87) };
            var vm3 = new Vermietung() { AbholStandort = s2, ZielStandort = s2, Auto = a3, Kunde = k3, Km = 74, Von = DateTime.Now.AddDays(-45), Bis = DateTime.Now.AddDays(-31) };

            Repository.Add(vm1);
            Repository.Add(vm2);
            Repository.Add(vm3);

            Repository.SaveAll();

        }
    }
}
