using Playground_ActivityIndicator.ViewModel;

namespace Playground_ActivityIndicator;

public partial class MainPage : ContentPage
{   
	public MainPage(MainPageViewModel mpvm)
	{
		InitializeComponent();
        BindingContext = mpvm;
	}
}

