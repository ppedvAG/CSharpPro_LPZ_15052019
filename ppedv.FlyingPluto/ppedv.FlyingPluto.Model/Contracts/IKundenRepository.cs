using System;
using System.Collections.Generic;

namespace ppedv.FlyingPluto.Model.Contracts
{
    public interface IKundenRepository : IRepository<Kunde>
    {
        IEnumerable<Kunde> GetBlaBlaKunden(int tage, DateTime datum);
    }

}
