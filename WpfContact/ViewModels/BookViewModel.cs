using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfContact.Utility;

namespace WpfContact.ViewModels
{
    public class BookViewModel : ObservableObject
    {
        private ContactsViewModel m_contactsVM;
        public ContactsViewModel ContactsVM
        {
            get { return m_contactsVM; }
            set { OnPropertyChanged(ref m_contactsVM, value); }
        }

        public ICommand LoadContatsCommand { get; private set; }
        public ICommand LoadFavoriteCommand { get; private set; }

        public BookViewModel()
        {
            ContactsVM = new ContactsViewModel();

            LoadContatsCommand = new RelayCommand(LoadContacts);
            LoadFavoriteCommand = new RelayCommand(LoadFavorites);
            
        }

        private void LoadContacts()
        {
            
        }

        private void LoadFavorites()
        {
            
        }

        
    }
}
