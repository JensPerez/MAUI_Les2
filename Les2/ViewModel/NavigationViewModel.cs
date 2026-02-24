using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.ViewModel
{
    [QueryProperty(nameof(Werknemer), "Werknemer")]
    public partial class NavigationViewModel : BaseViewModel
    {
        [ObservableProperty]
        Werknemer werknemer;

        partial void OnWerknemerChanged(Werknemer value)
        {
            if (werknemer == null)
            {
                Shell.Current.DisplayAlert("Error!", "Geen werknemer gevonden", "shit");
            }
        }

        [RelayCommand]
        public async void ToonInformatie()
        {
            await Shell.Current.DisplayAlertAsync("Werknemer Info", $"Werknemer: {werknemer.VolledigeNaam}", "Ok");
        }
    }
}
