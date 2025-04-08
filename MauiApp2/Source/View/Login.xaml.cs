
namespace MauiApp2.Source.View;

public partial class Login : ContentPage
{
    public Login() {
        InitializeComponent();
    }

    private void OnSignInClicked(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new DoctorSelectionPage(new ViewModel.DoctorSelectionPageViewModel()));
    }
}