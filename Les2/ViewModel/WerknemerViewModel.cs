using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Les2.Models;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.ViewModel
{
    public partial class WerknemerViewModel : BaseViewModel
    {
        [ObservableProperty]
        Werknemer werknemer;

        [ObservableProperty]
        ObservableCollection<Werknemer> werknemers;

        public WerknemerViewModel()
        {
            Title = "Werknemer toevoegen";
            Werknemers = [];
            Werknemer = new Werknemer();
        }

        [RelayCommand]

        private void WerknemerToevoegen()
        {
            werknemers.Add(Werknemer);
            Werknemer = new Werknemer();
        }

    }
}
