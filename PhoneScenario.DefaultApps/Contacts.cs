using PhoneScenario.Core;

namespace PhoneScenario.Apps.ContactsApp {
    public class Contacts : App {
        public Contacts() : base("Contacts") {
            Items = new GenericList<Contact>();
        }

        public GenericList<Contact> Items { get; }
    }
}
