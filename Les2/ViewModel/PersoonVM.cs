using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Les2.ViewModel
{
    public partial class PersoonVM : ObservableObject
    {
        [ObservableProperty]
        public string naam;

    }
}
