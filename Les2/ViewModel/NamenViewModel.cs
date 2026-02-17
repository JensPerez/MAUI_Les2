using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Les2.ViewModel
{
    public partial class NamenViewModel : BaseViewModel
    {

        [ObservableProperty]
        string naam;

        [ObservableProperty]
        ObservableCollection<string> namen;

        public NamenViewModel()
        {
            Naam = "";
            Namen = [];
            Title = "Namen Toevoegen";
        }

        [RelayCommand]
        private void NaamToevoegen()
        {
            if (!string.IsNullOrWhiteSpace(Naam))
            namen.Add(Naam);
            Naam = "";
        }

    }
}
