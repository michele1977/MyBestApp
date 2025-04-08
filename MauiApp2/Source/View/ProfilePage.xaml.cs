using MauiApp2.Source.Model;

namespace MauiApp2.Source.View;

public partial class ProfilePage : ContentView
{
    private Doctor _doctor;

    public ProfilePage(Doctor doctor) {
        InitializeComponent();
        _doctor = doctor;

        DoctorImage.Source = _doctor.ImageUrl;
        DoctorNameLabel.Text = _doctor.Name;
        DoctorSpecialtyLabel.Text = _doctor.Specialty;
        DoctorBioLabel.Text = _doctor.Bio;
        DoctorEmailLabel.Text = _doctor.Email;
        DoctorPhoneLabel.Text = _doctor.PhoneNumber;
    }
}