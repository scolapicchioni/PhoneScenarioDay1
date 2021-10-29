using PhoneScenario.Apps;
using PhoneScenario.Apps.CalculatorApp;
using PhoneScenario.Apps.CalendarApp;
using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Apps.WhatsAppApps;
using PhoneScenario.Core;
using PhoneScenario.DefaultApps;
using System;

namespace PhoneScenario.ConsoleApp  {
    public delegate double Calculation(double a, double b);
    class Program {
        static void Main(string[] args) {
            
        }

        private static void Day05_Delegates02() {
            Contacts app = new Contacts(new ContactsEFRepository());

            GenericList<Contact> contactsWithLongSurnames =
                app.Filter(IsTheSurnameLongerThan50Letters);

            GenericList<Contact> contactsLivingInGouda =
                app.Filter(contact => contact.HomeAddress.City == "Gouda");
        }

        static void Day05_Delegates01() {
            Calculator c1 = new Calculator();
            Calculation calculate = new Calculation(c1.Divide);
            calculate = c1.Divide;
            double res = calculate(3.4, 5.6);
            calculate = c1.Multiply;
            res = calculate(3.4, 5.6);



            Calculation toExecute = AskWhatCalculationToPerform();
            CalculateAndPrint(toExecute);
            CalculateAndPrint(Power);
            CalculateAndPrint(Math.Pow);

            CalculateAndPrint((double a, double b) => {
                return Math.Pow(a, b);
            });

            //lambda expression
            CalculateAndPrint((a, b) => Math.Pow(a, b));
        }

        static void Day05_DependencyInjection() {
            Contacts contacts = new Contacts(new ContactsEFRepository());
            StartApp(contacts);
            StartApp(new Calculator());

            Calendar cal = new Calendar(new AppointmentsEFRepository());
        }

        static bool IsTheSurnameLongerThan50Letters(Contact contact) {
            return contact.Surname.Length > 50;
        }

        static double Power(double a, double b) {
            return Math.Pow(a, b);
        }

        static void CalculateAndPrint(Calculation calculate) {
            Console.WriteLine("First number? ");
            string s1 = Console.ReadLine();
            double d1 = double.Parse(s1);

            Console.WriteLine("Second number? ");
            string s2 = Console.ReadLine();
            double d2 = double.Parse(s2);

            double result = calculate(d1, d2);

            Console.WriteLine($"The result is {result}");

        }



        static Calculation AskWhatCalculationToPerform() {
            Console.WriteLine("Type 1 for Add, 2 for Subtract, 3 for Multiply and 4 for Divide");
            string input = Console.ReadLine();
            Calculator c1 = new Calculator();
            switch (input) {
                case "1":
                    return c1.Add;
                case "2":
                    return c1.Subtract;
                case "3":
                    return c1.Multiply;
                case "4":
                    return c1.Divide;
                default:
                    return c1.Add;
            }
        }

        static void StartApp(App app) {
            app.Start();

            //if (app is Calendar) {
            //    Calendar c = app as Calendar;
            //    c.Start();
            //} else if (app is WhatsApp) { 
            
            //}
        }

        //static void StartApp(Calendar app) {
        //    app.Start();
        //}
        //static void StartApp(WhatsApp app) {
        //    app.Start();
        //}
        //static void StartApp(Contacts app) {
        //    app.Start();
        //}

        private static void Day04_VirtualOverrideDemo() {
            Contact contact = new Contact();
            contact.Name = "Simona";
            contact.Surname = "Colapicchioni";
            contact.PhoneNumber = "0612345678";
            string s = contact.ToString();
            Console.WriteLine(s);
            WriteLine(contact);
        }

        static void WriteLine(object value) {
            string s = value.ToString();
            Console.WriteLine(s);
        }


        private static void Day04_MoreInheritance() {
            Phone p1 = new Phone();

            p1.Apps.Add(new Calculator("john"));
            p1.Apps.Add(new Calendar(new AppointmentsEFRepository()));
            p1.Apps.Add(new Contacts(new ContactsEFRepository()));
            p1.Apps.Add(new WhatsApp());

            for (int i = 0; i < p1.Apps.Length; i++) {
                App app = p1.Apps.ItemAt(i);
                Console.WriteLine(app.Name);
            }

            try {
                Contacts contactsApp = p1.Apps.FindApp<Contacts>();
                Calculator calculatorApp = p1.Apps.FindApp<Calculator>();
            } catch (AppNotFoundException problem) {
                Console.WriteLine(problem.Message);
            }
        }

        //private static void Day03_WithoutInheritance() {
        //    /*
        //                 * As a USER
        //                 * I want a Calculator
        //                 * with Add, Subtract, Multiply, Divide
        //                 * so that I can calculate using the phone.
        //                 */

        //    /*
        //     * As a USER
        //     * I want an AGENDA 
        //     * so that I can keep my APPOINTMENTs.
        //     */

        //    //Calculator calc = new Calculator();
        //    //double result = calc.Add(4.5, 3.5);
        //    //Console.WriteLine(result);

        //    Phone samsung = new Phone();
        //    samsung.Brand = "Samsung";
        //    samsung.Model = "S5";

        //    double result = samsung.Calc.Add(4.5, 3.5);
        //    Console.WriteLine(result);
        //}

        //private static void Day02_CompleteScenario() {
        //    /*
        //    As a USER
        //    I want to give my two PHONEs to the TECHSUPPORT
        //    so that the CONTACTs are COPIED from one phone to the other


        //    USER
        //    PHONE
        //    TECHSUPPORT
        //    CONTACT

        //    COPY
        //    */
        //    Phone p1 = new Phone();

        //    Contact c = new Contact();
        //    c.Name = "Simona";
        //    c.Surname = "Colapicchioni";
        //    c.HomeAddress.City = "Rome";

        //    p1.Contacts.Items.Add(c);

        //    c = new Contact();

        //    c.Name = "Remko";
        //    c.Surname = "de Hoop";
        //    c.HomeAddress.City = "Gouda";

        //    p1.Contacts.Items.Add(c);

        //    Phone p2 = new Phone();

        //    c = new Contact();

        //    c.Name = "Jan Peter";
        //    c.Surname = "ten berge";

        //    p2.Contacts.Items.Add(c);

        //    TechSupport ts = new TechSupport();

        //    ts.CopyContacts(p1.Contacts.Items, p2.Contacts.Items);

        //    for (int i = 0; i < p2.Contacts.Items.Length; i++) {
        //        c = p2.Contacts.Items.ItemAt(i);
        //        Console.WriteLine(c.FullName);
        //    }
        //}

        private static void Day01_ArraysExample() {
            int[] myList = new int[10];
            myList[0] = 5;
            myList[1] = 10;
            myList[2] = 15;


            int[,,] matrix = new int[5, 3, 4];
            matrix[0, 0, 0] = 33;
            matrix[2, 2, 3] = 33;
        }

        private static void Day02_HomeAddress() {
            //Address myAddress = new Address();
            //myAddress.City = "Rome";
            //myAddress.State = "Italy";
            //myAddress.Street = "Viale Marx";
            //myAddress.StreetNumber = "319C";
            //myAddress.ZipCode = "00137";


            Contact c3 = new Contact();
            c3.Name = "Simona";
            c3.Surname = "Colapicchioni";
            c3.HomeAddress = new Address();
            c3.HomeAddress.City = "Gouda";
            c3.HomeAddress.Street = "Waterkers";
        }

        private static void Day01() {
            //try {
            //    //open file
            //    //open db
            //} catch (OpenFileException ex) {

            //} catch (DbExeption ex) { 

            //}

            try {
                Contact c1 = new Contact();
                c1.Name = "Simona"; //property set
                c1.PhoneNumber = "061234567";  //property set
                Console.WriteLine(c1.FullName); // "Mario Super"
                Console.WriteLine(c1.PhoneNumber); //property get

            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            try {
                Contact c2 = new Contact();
                c2.Name = "Mario234254235423456234523845623548"; //property set
                c2.Surname = "Super"; //property set
                c2.PhoneNumber = "06957293"; //property set
                Console.WriteLine(c2.FullName); // "Mario Super"
                Console.WriteLine(c2.PhoneNumber); //property get


                string p = c2.PhoneNumber; //property get
                Console.WriteLine(c2.PhoneNumber); //property get
                Console.WriteLine(c2.Name); //property get
            } catch {
                Console.WriteLine("ops, something went wrong....");
            }
        }
    }
}
