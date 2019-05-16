using System;

namespace ppedv.FlyingPluto.Model
{
    public class Vermietung : Entity
    {
        public DateTime Von { get; set; }
        public DateTime Bis { get; set; }
        public decimal Km { get; set; }
        public virtual Auto Auto { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Standort AbholStandort { get; set; }
        public virtual Standort ZielStandort { get; set; }
    }


}
