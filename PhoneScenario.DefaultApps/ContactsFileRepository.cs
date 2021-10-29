using PhoneScenario.Apps.ContactsApp;
using System;
using System.Collections.Generic;

namespace PhoneScenario.DefaultApps {
    public class ContactsFileRepository : IRepository<Contact> {
        public void Add(Contact contactToAdd) {
            //talk to File to add the contact to the DB
        }
        public void Delete(int id) {
            //talk to File to delete the contact from the DB given its Id
        }
        public void Update(Contact contactToUpdate) {
            //talk to File to update the contact in the DB
        }
        public List<Contact> GetAll() {
            //talk to File to read all the contacts from the DB
            throw new NotImplementedException();
        }
        public Contact GetById(int id) {
            //talk to File to find one contact in the DB given its Id
            throw new NotImplementedException();
        }
    }
}
