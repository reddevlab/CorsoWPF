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
            m_contacts = new List<Contact>();
            {
                new Contact
                {
                    Nome = "Red",
                    Interno = 342,
                    Emails = new string[]
                    {
                        "roberto.carrer@tesysoftware.com",
                        "roberto.carrer@me.com"
                    },


                };

                new Contact
                {
                    Nome = "Franco",
                    Interno = 357,
                    Emails = new string[]
                    {
                        "franco.martini@tesysoftware.com",
                        "franco.martini@me.com"
                    },


                };


            }


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
