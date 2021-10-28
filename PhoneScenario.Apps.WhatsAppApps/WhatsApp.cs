using System;
using PhoneScenario.Apps;
namespace PhoneScenario.Apps.WhatsAppApps {
    public class WhatsApp : App {
        public WhatsApp() : base("WhatsApp") {
        }
        //new WhatsApp("hi")
        public WhatsApp(string name) : base(name) {
            Name = name;
        }

        public override void Start() {
            Console.WriteLine("WhatsApp staring....");        
        }
    }
}
