

namespace Les2.Data
{
    public class WerknemerRepo : IWerknemerRepo
    {
        public List<Werknemer> GetWerknemers()
        {
            List<Werknemer> werknemer = new List<Werknemer>()
            {
                new Werknemer { ID = 1, Voornaam = "John", Achternaam = "Connor",
                    Functie = "Manager", GeboorteDatum = new DateTime(1987, 11, 23),
                    InDienst = new DateTime(2025, 01, 01)
                },

                new Werknemer { ID = 1, Voornaam = "Veerle", Achternaam = "Hers",
                    Functie = "Student", GeboorteDatum = new DateTime(1990, 2, 19),
                    InDienst = new DateTime(2025, 01, 01)
                },

                new Werknemer { ID = 1, Voornaam = "Kurt", Achternaam = "Kak",
                    Functie = "Foemp", GeboorteDatum = new DateTime(2011, 9, 15),
                    InDienst = new DateTime(2025, 01, 01)
                }


            };
            return werknemer;
        }
    }
}
