using Les2.ViewModel;

namespace Les2;

public partial class View : ContentPage
{
	public View(PersoonVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}