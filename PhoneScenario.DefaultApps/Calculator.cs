using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.Apps.CalculatorApp {
    public class Calculator : App {
        //public string Name { get; set; } = "Calculator";

        //constructor
        public Calculator() : base("Calculator") {
        }
        public Calculator(string name) : base(name) {
        }


        //with Add, Subtract, Multiply, Divide
        public double Add(double n1, double n2) {
            return n1 + n2;
        }
        public double Add(double n1, double n2, double n3) {
            return n1 + n2 + n3;
        }
        public int Add(int n1, int n2) {
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

        public override void Start() {
            Console.WriteLine("Calculator starting");
        }
    }
}
