using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Core;
using System;

namespace PhoneScenario.DefaultApps {
    public class ContactsEFRepository : IRepository<Contact>  {

        public void Add(Contact contactToAdd) {
            //talk to Entity Framework to add the contact to the DB
        }
        public void Delete(int id) {
            //talk to Entity Framework to delete the contact from the DB given its Id
        }
        public void Update(Contact contactToUpdate) {
            //talk to Entity Framework to update the contact in the DB
        }
        public GenericList<Contact> GetAll() {
            //talk to Entity Framework to read all the contacts from the DB
            GenericList<Contact> list = new GenericList<Contact>();
            list.Add(new Contact() { Name = "Simona", Surname = "Colapicchioni" });
            list.Add(new Contact() { Name = "Simona", Surname = "VeryLongSurname012345678901234567890123456789012345678901234567890123456789" });
            list.Add(new Contact() { Name = "John", Surname = "Doe" });
            list.Add(new Contact() { Name = "Mario", Surname = "VeryLongSurname012345678901234567890123456789012345678901234567890123456789" });
            return list;
        }
        public Contact GetById(int id) {
            //talk to Entity Framework to find one contact in the DB given its Id
            throw new NotImplementedException();
        }
    }
}
