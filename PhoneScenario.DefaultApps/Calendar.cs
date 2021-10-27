using PhoneScenario.Core;

namespace PhoneScenario.Apps.CalendarApp {
    public class Calendar : App {
        public Calendar() : base("Calendar") {
        }
        public Calendar(string name) : base(name) {
        }
        public GenericList<Appointment> Appointments { get; } = new GenericList<Appointment>();
    }
}
