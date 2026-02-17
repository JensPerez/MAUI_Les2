namespace Les2;

public partial class NamenPage : ContentPage
{
	public NamenPage(NamenViewModel vm)
	{
		InitializeComponent();
		
		BindingContext = vm;
	}
}