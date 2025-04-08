using MauiApp2.Source.Model;
using MauiApp2.Source.ViewModel;
using System.Numerics;
using System.Windows.Input;

namespace MauiApp2.Source.View;


    public partial class DoctorHomePage : ContentPage {
    private Doctor _doctor;

    public DoctorHomePage(Doctor doctor) {
        InitializeComponent();
        _doctor = doctor;

        // Mostra prima pagina di default
        MainContent.Content = new ProfilePage(_doctor);
    }

    private void GoToProfile(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);

    private void GoToDocuments(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);

    private void GoToAppointments(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);

    private void GoToDashboard(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);

    private void GoToDiet(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);

    private void GoToTraining(object sender, EventArgs e) =>
        MainContent.Content = new ProfilePage(_doctor);
}
