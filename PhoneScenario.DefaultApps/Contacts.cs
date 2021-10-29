using PhoneScenario.Core;
using PhoneScenario.DefaultApps;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PhoneScenario.Apps.ContactsApp {
    public class Contacts : App {
        private IRepository<Contact> _repository;
        public Contacts(IRepository<Contact> repository) : base("Contacts") {
            _repository = repository;
            Items = repository.GetAll();
        }

        public List<Contact> Items { get; }

        
        public delegate bool ContactChecker(Contact contactToCheck);
        //public List<Contact> Filter(ContactChecker checkContact) {
        //    List<Contact> result = new List<Contact>();
        //    for (int i = 0; i < Items.Count; i++) {
        //        Contact contact = Items.ElementAt(i);
        //        if (checkContact(contact)) {
        //            result.Add(contact);
        //        }
        //    }
        //    return result;
        //}

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
