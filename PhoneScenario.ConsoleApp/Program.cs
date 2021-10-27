using PhoneScenario.Apps;
using PhoneScenario.Apps.CalculatorApp;
using PhoneScenario.Apps.CalendarApp;
using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Apps.WhatsAppApps;
using System;

namespace PhoneScenario.ConsoleApp  {
    class Program {
        static void Main(string[] args) {
            Core.Phone p1 = new Core.Phone();

            p1.Apps.Add(new Calculator("john"));
            p1.Apps.Add(new Calendar());
            p1.Apps.Add(new Contacts());
            p1.Apps.Add(new WhatsApp());
            
            for (int i = 0; i < p1.Apps.Length; i++) {
                App app = p1.Apps.ItemAt(i);
                Console.WriteLine(app.Name); 
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
