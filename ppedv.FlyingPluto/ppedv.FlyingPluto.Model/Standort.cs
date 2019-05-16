using System.Collections.Generic;

namespace ppedv.FlyingPluto.Model
{
    public class Standort : Entity
    {
        public string Name { get; set; }
        public string Ort { get; set; }
        public string Chef { get; set; }

        public virtual HashSet<Auto> Auto { get; set; } = new HashSet<Auto>();
        public virtual HashSet<Vermietung> Ziel { get; set; } = new HashSet<Vermietung>();
        public virtual HashSet<Vermietung> Abhol { get; set; } = new HashSet<Vermietung>();

    }


}
