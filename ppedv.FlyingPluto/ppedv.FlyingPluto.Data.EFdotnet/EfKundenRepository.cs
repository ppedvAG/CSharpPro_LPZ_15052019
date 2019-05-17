using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Collections.Generic;

namespace ppedv.FlyingPluto.Data.EF
{
    public class EfKundenRepository : EfRepository<Kunde>, IKundenRepository
    {
        public EfKundenRepository(EfContext context) : base(context)
        { }

        public override void Add(Kunde entity)
        {
            base.Add(entity);
            //todo besser Add
        }

        public IEnumerable<Kunde> GetBlaBlaKunden(int tage, DateTime datum)
        {
            //todo call StoredProc
            //context.Database.ExecuteSqlCommand();
            throw new NotImplementedException();
        }
    }
}
