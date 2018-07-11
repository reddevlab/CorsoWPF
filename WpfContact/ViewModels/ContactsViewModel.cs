using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfContact.Models;
using WpfContact.Utility;

namespace WpfContact.ViewModels
{
    public class ContactsViewModel : ObservableObject
    {
        private Contact m_selContact;
        public Contact SelectedContact
        {
            get { return m_selContact; }
            set { OnPropertyChanged(ref m_selContact, value); }
        }

        public ObservableCollection<Contact> Contatcs { get; private set; }

        public ContactsViewModel()
        {

        }

        public void LoadContacts(IEnumerable<Contact> contatti)
        {
            Contatcs = new ObservableCollection<Contact>(contatti);
            OnPropertyChanged("Contatcs");
        }
    }
}
