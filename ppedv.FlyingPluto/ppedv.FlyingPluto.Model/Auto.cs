using System.Collections.Generic;

namespace ppedv.FlyingPluto.Model
{
    public class Auto : Entity
    {
        public string Kennzeichen { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string Farbe { get; set; }
        public int Sizte { get; set; }
        public bool Automatik { get; set; }

        public virtual Standort Standort { get; set; }
        public virtual HashSet<Vermietung> Mietungen { get; set; } = new HashSet<Vermietung>();

    }


}
