namespace Les2;

public partial class Oefening2 : ContentPage
{
	public Oefening2(Oefening2VM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}