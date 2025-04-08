using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp2.Model;
using MauiApp2.Source.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Source.ViewModel
{
    public class DoctorSelectionPageViewModel : ObservableObject {
        public ObservableCollection<Doctor> Doctors { get; set; } = new();


        public DoctorSelectionPageViewModel() {
            Doctors.Add(new Doctor { Name = "Dr. Laura Bianchi", Specialty = "Cardiologa", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Marco Verdi",   Specialty = "Neurologo", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Giulia Neri",   Specialty = "Pediatra", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Paolo Rossi",   Specialty = "Ortopedico", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Elisa Fontana", Specialty = "Dermatologa", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Matteo Costa",  Specialty = "Psicologo", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Laura Bianchi", Specialty = "Cardiologa", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Marco Verdi",   Specialty = "Neurologo", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Giulia Neri",   Specialty = "Pediatra", ImageUrl = "doctor.jpg" });
            Doctors.Add(new Doctor { Name = "Dr. Paolo Rossi",   Specialty = "Ortopedico", ImageUrl = "doctor.jpg" });
        }
    
    
    
    
    }
}
