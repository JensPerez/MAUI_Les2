namespace Les2.Data;

public class WerknemerRepo : IWerknemerRepo
{
    private List<Werknemer> werknemers = new List<Werknemer>();

    public WerknemerRepo()
    {
        GenerateStartWerknemers();
    }

    private void GenerateStartWerknemers()
    {
        werknemers = new List<Werknemer>()
        {
            new Werknemer
            {
                ID = 1, Voornaam = "John", Achternaam = "Connor",
                Functie = new Functie(){ID = 1, Naam = "Manager"}, GeboorteDatum = new DateTime(1987, 11, 23),
                InDienst = new DateTime(2025, 01, 01)
            },

            new Werknemer
            {
                ID = 2, Voornaam = "Jane", Achternaam = "Kendall",
                Functie = new Functie(){ID = 2, Naam = "Developer"}, GeboorteDatum = new DateTime(1977, 01, 23),
                InDienst = new DateTime(2024, 01, 01)
            },

            new Werknemer
            {
                ID = 3, Voornaam = "Gert", Achternaam = "Van Beech",
                Functie = new Functie(){ID = 3, Naam = "Designer"}, GeboorteDatum = new DateTime(1995, 12, 08),
                InDienst = new DateTime(2023, 01, 01)
            },

        };
    }


    public List<Werknemer> GetWerknemers()
    {

        return werknemers;
    }

    public void VoegWerknemerToe(Werknemer werknemer)
    {
        werknemers.Add(werknemer);
    }
}