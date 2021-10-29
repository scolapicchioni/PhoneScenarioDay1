using PhoneScenario.Core;
using PhoneScenario.DefaultApps;
using System;

namespace PhoneScenario.Apps.ContactsApp {
    public class Contacts : App {
        private IRepository<Contact> _repository;
        public Contacts(IRepository<Contact> repository) : base("Contacts") {
            _repository = repository;
            Items = repository.GetAll();
        }

        public GenericList<Contact> Items { get; }

        public GenericList<Contact> FilterBySurnameStartingWithA() {
            GenericList<Contact> result = new GenericList<Contact>();
            for (int i = 0; i < Items.Length; i++) {
                Contact contact = Items.ItemAt(i);
                if (contact.Surname.StartsWith("A")) {
                    result.Add(contact);
                }
            }
            return result;
        }
        public GenericList<Contact> FilterByMobile() {
            GenericList<Contact> result = new GenericList<Contact>();
            for (int i = 0; i < Items.Length; i++) {
                Contact contact = Items.ItemAt(i);
                if (contact.PhoneNumber.StartsWith("06")) {
                    result.Add(contact);
                }
            }
            return result;
        }
        public delegate bool ContactChecker(Contact contactToCheck);
        public GenericList<Contact> Filter(ContactChecker checkContact) {
            GenericList<Contact> result = new GenericList<Contact>();
            for (int i = 0; i < Items.Length; i++) {
                Contact contact = Items.ItemAt(i);
                if (checkContact(contact)) {
                    result.Add(contact);
                }
            }
            return result;
        }

        public override void Start() {
            Console.WriteLine("Contacts app starting...");
        }
        public void CreateContact(Contact c) {
            _repository.Add(c);
        }
        public void EditContact(Contact c) {
            _repository.Update(c);
        }
        public void RemoveContact(Contact c) {
            _repository.Delete(0);
        }
    }
}
