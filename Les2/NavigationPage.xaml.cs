namespace Les2;

public partial class NavigationPage : ContentPage
{
	public NavigationPage(NavigationViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}