using System;

namespace PhoneScenario.Apps.ContactsApp {
    public class Contact {
        //backing field
        private string name;

        //property
        public string Name {
            //c1.Name = "Simona";
            set //value = "Simona"
            {
                if (value.Length > 10) {
                    throw new ArgumentException("Name cannot be longer than 10 letters!");
                }
                name = value;
            }
            //string n = c1.Name;
            get {
                return name;
            }
            //get => name;
        }

        //private string surname;
        //public string Surname {
        //    set {
        //        surname = value;
        //    }
        //    get { 
        //        return surname;  
        //    }
        //}

        public string Surname { get; set; }
        //public string FullName 
        //{ 
        //    get 
        //    { 
        //        return Name + " " + Surname; 
        //    } 
        //}
        public string FullName => $"{Name.ToUpper()} - {Surname}";

        //backing field
        private string phoneNumber;

        //c1.SetPhoneNumber("061234567"); //method invocation; "061234567"== argument
        //public void SetPhoneNumber(string newPhoneNumber) 
        //{
        //    if (newPhoneNumber.Length > 50) 
        //    {
        //        phoneNumber = newPhoneNumber.Substring(0, 50);
        //    } 
        //    else 
        //    {
        //        phoneNumber = newPhoneNumber;
        //    }
        //}


        ////string p = c1.GetPhoneNumber();
        //public string GetPhoneNumber() 
        //{
        //    return phoneNumber;
        //}

        public string PhoneNumber {
            set {
                if (value is null || value.Length <= 50) {
                    phoneNumber = value;
                } else {
                    phoneNumber = value.Substring(0, 50);
                }
            }


            //string p = c1.GetPhoneNumber();
            get {
                return phoneNumber;
            }
        }

        //HAS A relationship
        public Address HomeAddress { get; set; } = new Address();
        //public Address WorkAddress { get; set; }

        public void CopyTo(Contact target) {
            target.Name = this.Name;
            target.Surname = Surname;
            target.PhoneNumber = PhoneNumber;

            HomeAddress.CopyTo(target.HomeAddress);
        }

    }


}
