using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfContact.Services;
using WpfContact.Utility;

namespace WpfContact.ViewModels
{
    public class BookViewModel : ObservableObject
    {

        private IContactDataService m_service;

        private ContactsViewModel m_contactsVM;
        public ContactsViewModel ContactsVM
        {
            get { return m_contactsVM; }
            set { OnPropertyChanged(ref m_contactsVM, value); }
        }

        public ICommand LoadContatsCommand { get; private set; }
        public ICommand LoadFavoriteCommand { get; private set; }

        public BookViewModel(IContactDataService service)
        {
            m_service = service;
            ContactsVM = new ContactsViewModel();

            LoadContatsCommand = new RelayCommand(LoadContacts);
            LoadFavoriteCommand = new RelayCommand(LoadFavorites);
            
        }

        private void LoadContacts()
        {
            MockDataService service = new MockDataService();
            ContactsVM.LoadContacts(service.GetContacts());
        }

        private void LoadFavorites()
        {
            var fav = m_service.GetContacts().Where(c => c.IsFavorite);
            ContactsVM.LoadContacts(fav);
        }

        
    }
}
