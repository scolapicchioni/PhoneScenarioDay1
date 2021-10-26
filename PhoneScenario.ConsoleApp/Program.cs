using System;

namespace PhoneScenario.ConsoleApp {
    class Program {
        static void Main(string[] args) 
        {

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

            } 
            catch (ArgumentException ex) 
            {
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
