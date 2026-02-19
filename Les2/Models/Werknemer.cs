using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.Models
{
    public class Werknemer
    {
        public int ID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public Functie Functie { get; set; }
        public DateTime GeboorteDatum { get; set; } = new DateTime(1990, 1, 1);
        public DateTime InDienst { get; set; } = DateTime.Now;
        public string VolledigeNaam { get => $"{Voornaam} {Achternaam}"; }






    }
}
