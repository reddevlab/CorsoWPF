using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfContact.Models;

namespace WpfContact.Services
{
    public class MockDataService : IContactDataService
    {
        private IEnumerable<Contact> m_contacts;

        public MockDataService()
        {
            m_contacts = new List<Contact>()
            {
                new Contact
                {
                    Nickname = "Red",
                    Interno = 342,
                    Emails = new string[]
                    {
                        "r.cc@tssoftware.com",
                        "r.cc@me.com"
                    },


                },

                new Contact
                {
                    Nickname = "Franco",
                    Interno = 357,
                    Emails = new string[]
                    {
                        "f.mm@tssoftware.com",
                        "f.mm@me.com"
                    },


                },
            };

        }

        public IEnumerable<Contact> GetContacts()
        {
            return m_contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            m_contacts = contacts;
        }
    }
}
