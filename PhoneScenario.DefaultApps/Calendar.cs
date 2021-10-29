using PhoneScenario.Core;
using PhoneScenario.DefaultApps;
using System;

namespace PhoneScenario.Apps.CalendarApp {
    public class Calendar : App {
        private readonly IRepository<Appointment> repository;

        public Calendar(IRepository<Appointment> repository) : base("Calendar") {
            this.repository = repository;
            Appointments = repository.GetAll();
        }
        public Calendar(string name) : base(name) {
        }
        public GenericList<Appointment> Appointments { get; } = new GenericList<Appointment>();

        public override void Start() {
            Console.WriteLine("Calendar starting");
        }
    }
}
