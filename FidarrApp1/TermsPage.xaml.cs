namespace FidarrApp1;

public partial class TermsPage : ContentPage
{
	public TermsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }
}