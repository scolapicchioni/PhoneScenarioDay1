using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class TechSupport {
        public void CopyContacts(ListOfContacts source, ListOfContacts target) 
        {
            //for (int i = 0; i < source.Contacts.Length && source.Contacts[i] is not null; i++) {}

            int i = 0;
            while (i < source.Length && source.ItemAt(i) is not null) {
                //make a new contact
                Contact newContact = new Contact();
                
                //retrieve source contact
                Contact sourceContact = source.ItemAt(i);

                //copy the source contact on the new contact (ask, don't tell)
                sourceContact.CopyTo(newContact);

                //add the new contact to the target phone
                target.Add(newContact);

                i++;
            }
        }
    }
}
