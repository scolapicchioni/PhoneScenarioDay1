using PhoneScenario.Apps.ContactsApp;
using PhoneScenario.Core;
using System;
using System.Collections.Generic;

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
        public List<Contact> GetAll() {
            //talk to Entity Framework to read all the contacts from the DB
            return new List<Contact>() {
                new Contact() { Name = "Simona", Surname = "Colapicchioni" },
                new Contact() { Name = "Simona", Surname = "VeryLongSurname012345678901234567890123456789012345678901234567890123456789" },
                new Contact() { Name = "John", Surname = "Doe" },
                new Contact() { Name = "Mario", Surname = "VeryLongSurname012345678901234567890123456789012345678901234567890123456789" }
            };
        }
        public Contact GetById(int id) {
            //talk to Entity Framework to find one contact in the DB given its Id
            throw new NotImplementedException();
        }
    }
}
