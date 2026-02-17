using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.ViewModel
{
    public partial class Oefening2VM : ObservableObject
    {
        [ObservableProperty]
        public string naam, geslacht, email, telefoonNr, resultaat;

        public Oefening2VM()
        {
            Naam = "Michiel";
            Geslacht = "M";
            Email = "michiel.wouters@hotmail.com";
            TelefoonNr = "0420.69.69.87";
            Resultaat = String.Empty;
        }

        [RelayCommand]
        public void UitvoerTonen()
        {
            Resultaat = $"Dag {Naam}, je email is {Email}, en je geslacht is {Geslacht}";
        }
    }
}
