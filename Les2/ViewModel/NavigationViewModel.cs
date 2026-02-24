using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.ViewModel
{
    [QueryProperty(nameof(Werknemer), "Werknemer1")]
    public partial class NavigationViewModel : BaseViewModel
    {
        [ObservableProperty]
        Werknemer werkNemerDetail;

        [RelayCommand]
        public async void ToonInformatie()
        {
            await Shell.Current.DisplayAlertAsync("Werknemer Info", $"Werknemer: {werkNemerDetail.VolledigeNaam}", "Ok");
        }
    }
}
