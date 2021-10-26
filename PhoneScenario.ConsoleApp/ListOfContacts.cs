using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class ListOfContacts {
        private Contact[] contacts = new Contact[10];
        private int count = 0;

        public int Length {
            get {
                return count;
            }
        }

        //p1.AddContact(c1);
        //p1.AddContact(c2);
        public void Add(Contact contact) {
            contacts[count] = contact;
            count = count + 1;
        }

        //Contact c = p2.ContactAt(1);
        public Contact ItemAt(int index) {
            return contacts[index];
        }
    }
}
