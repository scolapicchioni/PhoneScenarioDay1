using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.Apps {
    public class App {
        //public App() {
            
        //}
        public App(string name) {
            Name = "This is an app with this name: " + name;
        }
        public string Name { get; set; }
    }
}
