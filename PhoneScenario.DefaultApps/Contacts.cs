using PhoneScenario.Core;
using System;

namespace PhoneScenario.Apps.ContactsApp {
    public class Contacts : App {
        public Contacts() : base("Contacts") {
            Items = new GenericList<Contact>();
        }

        public GenericList<Contact> Items { get; }

        public override void Start() {
            Console.WriteLine("Contacts app starting...");
        }
    }
}
