using System;
using System.Collections.Generic;

namespace ppedv.FlyingPluto.Model
{
    public class Kunde : Entity
    {
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
        public virtual HashSet<Vermietung> Mietungen { get; set; } = new HashSet<Vermietung>();

    }


}
