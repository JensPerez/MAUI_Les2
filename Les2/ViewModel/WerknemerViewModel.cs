using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Les2.Data;
using Les2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Les2.ViewModel
{
    public partial class WerknemerViewModel : BaseViewModel
    {
        [ObservableProperty]
        Werknemer werknemer;

        [ObservableProperty]
        ObservableCollection<Werknemer> werknemers;

        [ObservableProperty]
        ObservableCollection<Functie> functies;

        // Compositie. AKA klasse heeft dependency op andere klasse(s).
        private IWerknemerRepo _werknemerRepo;
        private IFunctieRepo _functieRepo;

        public WerknemerViewModel(IWerknemerRepo werknemerRepo, IFunctieRepo functieRepo) //** vragen in de parameters is Dependancy Injection
        {
            Title = "Werknemer toevoegen";
            Werknemer = new Werknemer();
            _werknemerRepo = werknemerRepo; // <--  Dependency Injection **
            _functieRepo = functieRepo;
            Werknemers = new ObservableCollection<Werknemer>(_werknemerRepo.GetWerknemers());
            Functies = new ObservableCollection<Functie>(_functieRepo.GetFuncties());
        }

        [RelayCommand]
        private void WerknemerToevoegen()
        {
            // Werknemers.Add(Werknemer);
            _werknemerRepo.VoegWerknemerToe(Werknemer);
            Werknemers = new ObservableCollection<Werknemer>(_werknemerRepo.GetWerknemers());
            Werknemer = new Werknemer();
        }

        [RelayCommand]
        private async void GoToNavigation(Werknemer werknemer)
        {



            // BELANGRIJK!!!!!!!!!!!!!!!!!!!! Examenvraag
            await Shell.Current.GoToAsync(nameof(NavigationPage),true, new Dictionary<string, object> { { "Werknemer", werknemer } });

        }

    }
}
