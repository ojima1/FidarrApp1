namespace FidarrApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new RegistrationPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ForgotPassword());

    }

    private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TermsPage());
    }
}

