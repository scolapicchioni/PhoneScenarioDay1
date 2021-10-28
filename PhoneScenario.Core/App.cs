using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.Apps {
    public abstract class App {
        protected int id;
        public int Id { get; init; }
        //public App() {
            
        //}
        public App(string name) {
            Name = name;
            Id = 5;
        }
        public string Name { get; protected set; }

        public abstract void Start();

        //public void ChangeId() {
        //    Id = 44;
        //}
    }
}
