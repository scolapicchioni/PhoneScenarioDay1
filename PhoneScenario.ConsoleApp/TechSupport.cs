using PhoneScenario.Apps;
using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Core;

namespace PhoneScenario.ConsoleApp {
    class TechSupport {
        public Contacts FindContactsApp(Phone phone) {
            Contacts foundApp = null;
            int index = 0;
            while (index <= phone.Apps.Length || foundApp is null) {
                App a = phone.Apps.ItemAt(index);
                
                if (a is Contacts) {
                    foundApp = (Contacts)a; //cast    
                }
                index++;
            }

            if (foundApp is null) {
                throw new ContactsAppNotFoundException("Sorry, we could not find the Contacts App");
            }
            return foundApp;
        }

        public void CopyContacts(GenericList<Contact> source, GenericList<Contact> target) {
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
        public void CopyContacts(Phone source, Phone target) {
            GenericList<Contact> sourceList = FindContactsApp(source).Items;
            GenericList<Contact> targetList = FindContactsApp(target).Items;

            CopyContacts(sourceList, targetList);
        }
    }
}
