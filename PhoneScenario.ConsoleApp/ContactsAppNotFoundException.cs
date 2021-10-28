using System;

namespace PhoneScenario.ConsoleApp {
    class ContactsAppNotFoundException : Exception {
        public ContactsAppNotFoundException(string message) : base(message) { 
            
        }
    }
}
