using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.Models
{
    public class Functie
    {
        public int ID { get; set; }
        public string Naam { get; set; }

        public override string ToString()
        {
            return Naam;
        }

        public override bool Equals(object? obj)
        {
            return obj is Functie functie && functie.Naam == Naam;
        }
    }
}
