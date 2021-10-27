using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Calculator {
        public string Name { get; set; } = "Calculator";
        //with Add, Subtract, Multiply, Divide
        public double Add(double n1, double n2) {
            return n1 + n2;
        }
        public double Subtract(double n1, double n2) {
            return n1 - n2;
        }
        public double Multiply(double n1, double n2) {
            return n1 * n2;
        }
        public double Divide(double n1, double n2) {
            return n1 / n2;
        }
    }
}
