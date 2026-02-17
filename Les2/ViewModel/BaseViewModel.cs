using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les2.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title;

        [RelayCommand]
        public static async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
