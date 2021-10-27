using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Contacts {
        public string Name { get; set; }
        public GenericList<Contact> Items { get; } = new GenericList<Contact>();
    }
}
