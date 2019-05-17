using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;

namespace ppedv.FlyingPluto.Logic.Tests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void Core_GetAllKundenDieSeitXXNichtMehrGebuchtHaben_tage_negative_throws_ArguementException()
        {
            var core = new Core(null);

            Assert.ThrowsException<ArgumentException>(() => core.Kunden.GetAllKundenDieSeitXXNichtMehrGebuchtHaben(-1, DateTime.Now));

        }


        [TestMethod]
        public void Core_GetAllKundenDieSeitXXNichtMehrGebuchtHaben()
        {
            var repoMock = new Mock<IKundenRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.Setup(x => x.GetRepository<Kunde>()).Returns(repoMock.Object);
            uowMock.Setup(x => x.KundenRepo).Returns(repoMock.Object);

            var core = new Core(uowMock.Object);

            repoMock.Setup(x => x.Query()).Returns(() =>
            {
                var k1 = new Kunde() { Name = "K1" };
                var k2 = new Kunde() { Name = "K2" };

                var vm1 = new Vermietung() { Bis = DateTime.Now.AddDays(-50), Kunde = k1 };
                var vm2 = new Vermietung() { Bis = DateTime.Now.AddDays(-150), Kunde = k2 };
                k1.Mietungen.Add(vm1);
                k2.Mietungen.Add(vm2);

                return new[] { k1, k2 }.AsQueryable();
            });

            var result = core.Kunden.GetAllKundenDieSeitXXNichtMehrGebuchtHaben(100, DateTime.Now);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("K2", result.First().Name);

        }

    }
}
