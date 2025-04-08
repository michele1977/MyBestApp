using MauiApp2.Model;
using MauiApp2.Source.ViewModel;
using System.Collections.ObjectModel;

namespace MauiApp2.Source.View; 
public partial class DoctorSelectionPage : ContentPage
{

    public DoctorSelectionPage(DoctorSelectionPageViewModel ViewModel) {
        InitializeComponent();
        BindingContext = ViewModel;
    }

}