using PhoneScenario.Apps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.Core {
    public class ListOfApps : List<App> {
        public TheTypeOfAppToFind FindApp<TheTypeOfAppToFind>() where TheTypeOfAppToFind : App {
            TheTypeOfAppToFind foundApp = default;
            int index = 0;
            while (index <= Count || foundApp is null) {
                App a = this.ElementAt(index);
                //foundApp = a as TheTypeOfAppToFind;
                if (a is TheTypeOfAppToFind) {
                    foundApp = (TheTypeOfAppToFind)a; //cast    
                }
                index++;
            }

            if (foundApp is null) {
                throw new AppNotFoundException($"Sorry, we could not find the {foundApp.GetType().Name} App");
            }
            return foundApp;
        }

    }
}
