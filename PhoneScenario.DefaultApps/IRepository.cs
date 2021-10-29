using PhoneScenario.Apps.CalendarApp;
using PhoneScenario.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneScenario.DefaultApps {
    public interface IRepository<T> {
        GenericList<T> GetAll();
        T GetById(int id);
        void Update(T contactToUpdate);
        void Add(T contactToAdd);
        void Delete(int id);
    }
}
