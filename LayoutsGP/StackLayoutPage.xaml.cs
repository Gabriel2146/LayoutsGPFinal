namespace LayoutsGP;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }
}