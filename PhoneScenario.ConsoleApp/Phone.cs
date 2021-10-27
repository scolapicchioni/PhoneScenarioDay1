using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Phone {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public Contacts Contacts { get; set; } = new Contacts();
        public Calculator Calc { get; set; } = new Calculator();
        public Calendar Agenda { get; set; } = new Calendar();
    }
}
