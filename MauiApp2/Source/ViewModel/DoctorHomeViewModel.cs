using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp2.Source.ViewModel
{
    public class DashboardItem {
        public string Label { get; set; }
        public ICommand Command { get; set; }
    }

    public class DoctorHomeViewModel {
        public ObservableCollection<DashboardItem> DashboardItems { get; set; }

        public DoctorHomeViewModel() {
            DashboardItems = new ObservableCollection<DashboardItem>
            {
            new DashboardItem { Label = "👤 Profilo", Command = new Command(OnProfilo) },
            new DashboardItem { Label = "📄 Documenti", Command = new Command(OnDocumenti) },
            new DashboardItem { Label = "📅 Appuntamenti", Command = new Command(OnAppuntamenti) },
            new DashboardItem { Label = "📊 Dashboard", Command = new Command(OnDashboard) },
            new DashboardItem { Label = "🥗 Dieta", Command = new Command(OnDieta) },
            new DashboardItem { Label = "🏋️ Allenamento", Command = new Command(OnAllenamento) },
        };
        }

        // metodi finti per esempio
        private void OnProfilo() { }
        private void OnDocumenti() { }
        private void OnAppuntamenti() { }
        private void OnDashboard() { }
        private void OnDieta() { }
        private void OnAllenamento() { }
    }

}
