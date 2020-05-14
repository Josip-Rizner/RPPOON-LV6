using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class CareTaker
    {
        private List<Memento> PreviousStates { get; set; }
        public CareTaker()
        {
            this.PreviousStates = new List<Memento>();
        }
        public void AddMemento(Memento memento)
        {
            this.PreviousStates.Add(memento);
        }

        public void Clear()
        {
            this.PreviousStates.Clear();
        }

        public Memento GetMementoAt(int index)
        {
            return this.PreviousStates[index];
        }
    }
}
