using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Source.Model
{
    public class Doctor {
        public Guid Id { get; set; }

        // Informazioni anagrafiche
        public string Name { get; set; }

        // Specializzazione del medico
        public string Specialty { get; set; }

        // Contatti
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Eventuale immagine profilo (URL o base64)
        public string ImageUrl { get; set; }

        // Biografia o descrizione del medico
        public string Bio { get; set; }


    }
}
