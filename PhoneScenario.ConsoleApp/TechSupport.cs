using PhoneScenario.Apps;
using PhoneScenario.Apps.CalculatorApp;
using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Apps.WhatsAppApps;
using PhoneScenario.Core;
using System;

namespace PhoneScenario.ConsoleApp {
    class TechSupport {
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
            GenericList<Contact> sourceList = source.Apps.FindApp<Contacts>().Items;
            GenericList<Contact> targetList = target.Apps.FindApp<Contacts>().Items;

            CopyContacts(sourceList, targetList);
        }
    }
}
