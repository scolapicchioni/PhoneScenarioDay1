using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Rectangle {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;
        //public double Area() => Width * Height;  
    }
}
