using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.Data
{
    public class FunctieRepo : IFunctieRepo
    {
        public List<Functie> GetFuncties()
        {
            List<Functie> functies = new List<Functie>()
            {
                new Functie() {ID = 1, Naam = "Manager"},
                new Functie() {ID = 2, Naam = "Developer"},
                new Functie() {ID = 3, Naam = "Designer"}
            };
            return functies;
        }
    }
}
