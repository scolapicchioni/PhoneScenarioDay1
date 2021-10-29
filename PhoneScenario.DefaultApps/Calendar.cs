using PhoneScenario.Core;
using PhoneScenario.DefaultApps;
using System;
using System.Collections.Generic;

namespace PhoneScenario.Apps.CalendarApp {
    public class Calendar : App {
        private readonly IRepository<Appointment> repository;

        public Calendar(IRepository<Appointment> repository) : base("Calendar") {
            this.repository = repository;
            Appointments = repository.GetAll();
        }
        public Calendar(string name) : base(name) {
        }
        public List<Appointment> Appointments { get; } = new List<Appointment>();

        public override void Start() {
            Console.WriteLine("Calendar starting");
        }
    }
}
