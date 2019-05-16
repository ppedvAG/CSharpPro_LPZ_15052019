using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ppedv.FlyingPluto.Model;

namespace ppedv.FlyingPluto.Data.EF.Tests
{
    [TestClass]
    public class EfContexTests
    {
        [TestMethod]
        public void EfContext_can_create_db()
        {
            using (var con = new EfContext())
            {
                if (con.Database.Exists())
                    con.Database.Delete();

                Assert.IsFalse(con.Database.Exists());
                con.Database.Create();
                Assert.IsTrue(con.Database.Exists());
            }
        }

        [TestMethod]
        public void EfContext_CRUD_Kunde()
        {
            var k = new Kunde() { Name = $"Fred_{Guid.NewGuid()}", GebDatum = new DateTime(2000, 1, 1) };
            var newName = $"Wilma_{Guid.NewGuid()}";

            //CREAT
            using (var con = new EfContext())
            {
                con.Kunden.Add(k);
                con.SaveChanges();
            }

            //READ
            using (var con = new EfContext())
            {
                var loaded = con.Kunden.Find(k.Id);
                Assert.IsNotNull(loaded);
                Assert.AreEqual(k.Name, loaded.Name);

                //UPDATE
                loaded.Name = newName;
                con.SaveChanges();
            }

            //check UPDATE
            using (var con = new EfContext())
            {
                var loaded = con.Kunden.Find(k.Id);
                Assert.AreEqual(newName, loaded.Name);

                //DELETE
                con.Kunden.Remove(loaded);
                con.SaveChanges();
            }

            //check DELETE
            using (var con = new EfContext())
            {
                var loaded = con.Kunden.Find(k.Id);
                Assert.IsNull(loaded);
            }
        }
    }
}
