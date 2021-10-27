using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Calendar {
        public string Name { get; set; } = "Calendar";
        public GenericList<Appointment> Appointments { get; } = new GenericList<Appointment>();
    }
}
