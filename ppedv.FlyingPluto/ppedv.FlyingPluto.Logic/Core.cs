using ppedv.FlyingPluto.Data.EF;
using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.FlyingPluto.Logic
{
    public class Core
    {
        public IUnitOfWork UoW { get; private set; }

        public VermietungsService Vermietung { get => new VermietungsService(this); }
        public KundenService Kunden { get => new KundenService(this); }

        public Core(IUnitOfWork uow) //todo: DP Injection in here
        {
            UoW = uow;
        }
        public Core() : this(new Data.EF.EfUnitOfWork())
        { }

        public void CreateDemoData()
        {
            var k1 = new Kunde() { Name = "Fred", GebDatum = DateTime.Now.AddYears(40) };
            var k2 = new Kunde() { Name = "Wilma", GebDatum = DateTime.Now.AddYears(29) };
            var k3 = new Kunde() { Name = "Barney", GebDatum = DateTime.Now.AddYears(35) };

            var s1 = new Standort() { Name = "Zentrale", Chef = "Sache" };
            var s2 = new Standort() { Name = "Außenbezirk", Chef = "Koch" };

            var a1 = new Auto() { Marke = "Borsche", Modell = "811", Farbe = "Grün", Sizte = 3, Kennzeichen = "XX-XX-000", Automatik = true };
            var a2 = new Auto() { Marke = "Bercedes", Modell = "K-Klasse", Farbe = "Gelb", Sizte = 12, Kennzeichen = "XX-XX-000", Automatik = true };
            var a3 = new Auto() { Marke = "Bopel", Modell = "Bastra", Farbe = "Blau", Sizte = 4, Kennzeichen = "XX-XX-000", Automatik = false };

            var vm1 = new Vermietung() { AbholStandort = s1, ZielStandort = s2, Auto = a1, Kunde = k1, Km = 100, Von = DateTime.Now.AddDays(-15), Bis = DateTime.Now.AddDays(-11) };
            var vm2 = new Vermietung() { AbholStandort = s1, ZielStandort = s1, Auto = a2, Kunde = k2, Km = 11, Von = DateTime.Now.AddDays(-95), Bis = DateTime.Now.AddDays(-87) };
            var vm3 = new Vermietung() { AbholStandort = s2, ZielStandort = s2, Auto = a3, Kunde = k3, Km = 74, Von = DateTime.Now.AddDays(-45), Bis = DateTime.Now.AddDays(-31) };

            UoW.GetRepository<Vermietung>().Add(vm1);
            UoW.GetRepository<Vermietung>().Add(vm2);
            UoW.GetRepository<Vermietung>().Add(vm3);

            UoW.SaveAll();

        }
    }
}
