using MauiApp2.Source.Model;
using MauiApp2.Source.View;
using MauiApp2.Source.ViewModel;
using System.Windows.Input;

namespace MauiApp2.Source.Component;

public partial class DoctorCard : ContentView {




    public static readonly BindableProperty ParamDoctorProperty =
        BindableProperty.Create(nameof(ParamDoctor), typeof(Doctor), typeof(DoctorCard), default(Doctor));




    public Doctor ParamDoctor {
        get => (Doctor)GetValue(ParamDoctorProperty);
        set => SetValue(ParamDoctorProperty, value);
    }





    private void OnFrameTapped(object obj, EventArgs evt) {
        Console.WriteLine("Frame cliccato!");
        Navigation.PushAsync(new DoctorHomePage(ParamDoctor));

    }



    public DoctorCard() {

        InitializeComponent();

    }
}