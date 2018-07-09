using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfContact.Utility;
using WpfContact.ViewModels;

namespace WpfContact
{
    public class AppViewModel : ObservableObject
    {
        private object m_currentView;
        public Object CurrentView
        {
            get { return m_currentView;  }
            set
            {
                OnPropertyChanged(ref m_currentView, value);
            }
        }

        private BookViewModel m_bookVM;
        public BookViewModel BookVM
        {
            get { return m_bookVM; }
            set { OnPropertyChanged(ref m_bookVM, value); }
        }

        public AppViewModel()
        {
            BookVM = new BookViewModel();
            CurrentView = BookVM;
        }

    }
}
