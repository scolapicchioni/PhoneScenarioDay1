using System;

namespace PhoneScenario.Core {
    public class AppNotFoundException : Exception {
        public AppNotFoundException(string message) : base(message) {

        }
    }
}
