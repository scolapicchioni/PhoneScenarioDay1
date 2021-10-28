using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.Apps.WhatsAppApps {
    public class Facebook : App {
        public Facebook(string name) : base(name) {
        }
        public override void Start() {
            Console.WriteLine("Facebook is starting....");
        }
    }
}
