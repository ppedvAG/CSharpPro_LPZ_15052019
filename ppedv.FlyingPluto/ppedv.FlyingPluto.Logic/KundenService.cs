using ppedv.FlyingPluto.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.FlyingPluto.Logic
{
    public class KundenService
    {
        private Core core;

        public KundenService(Core core)
        {
            this.core = core;
        }

        public IEnumerable<Kunde> GetAllKundenDieSeitXXNichtMehrGebuchtHaben(int tage, DateTime now)
        {
            if (tage < 0)
                throw new ArgumentException();

            return core.UoW.GetRepository<Kunde>().Query().ToList().Where(x => x.Mietungen.Count() > 0 && (now - x.Mietungen.OrderBy(y => y.Bis).FirstOrDefault().Bis).TotalDays > tage);
            return core.UoW.KundenRepo.Query().ToList().Where(x => x.Mietungen.Count() > 0 && (now - x.Mietungen.OrderBy(y => y.Bis).FirstOrDefault().Bis).TotalDays > tage);
            return core.UoW.KundenRepo.GetBlaBlaKunden(tage, now);
        }
    }
}
