using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.ConsoleApp {
    class Address {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Province { get; set; }

        public void CopyTo(Address target) {
            target.Street = Street;
            target.StreetNumber = StreetNumber;
            target.ZipCode = ZipCode;
            target.City = City;
            target.State  = State;
            target.Province = Province;
        }
    }
}
