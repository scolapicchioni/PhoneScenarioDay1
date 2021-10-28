using Microsoft.EntityFrameworkCore;
using PhoneScenario.Apps;
using System.Collections.Generic;

namespace PhoneScenario.Core {
    public class Phone {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        //public Contacts Contacts { get; set; } = new Contacts();
        //public Calculator Calc { get; set; } = new Calculator();
        //public Calendar Agenda { get; set; } = new Calendar();
        public GenericList<App> Apps { get; set; } = new GenericList<App>();
        public Phone() {
            
        }
    }
}
