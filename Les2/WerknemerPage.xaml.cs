namespace Les2;

public partial class WerknemerPage : ContentPage
{
	public WerknemerPage(WerknemerViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}