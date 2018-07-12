using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfContact.Utility;

namespace WpfContact.Models
{
    public class Contact : ObservableObject
    {
        public string Nickname { get; set; }
        public string Cognome { get; set; }
        public int Interno { get; set; }

        private string m_nomecompleto;
        public string NomeCompleto
        {
            get { return m_nomecompleto; }
            set { OnPropertyChanged(ref m_nomecompleto, value); }
        }

        private string[] m_telefoni;
        public string[] PhoneNumbers
        {
            get { return m_telefoni; }
            set { OnPropertyChanged(ref m_telefoni, value); }
        }

        private string[] m_emails;
        public string[] Emails
        {
            get { return m_emails; }
            set { OnPropertyChanged(ref m_emails, value); }
        }

        private string[] _locations;
        public string[] Locations
        {
            get { return _locations; }
            set { OnPropertyChanged(ref _locations, value); }
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set { OnPropertyChanged(ref _isFavorite, value); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { OnPropertyChanged(ref _imagePath, value); }
        }
    }
}
