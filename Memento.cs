using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class Memento
    {

        /*          3. zadatak
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Memento(string title, string text, DateTime timeDue, DateTime creationTime)
        {
            this.Title = title;
            this.Text = text;
            this.TimeDue = timeDue;
            this.CreationTime = creationTime;
        }*/



        public string ownerName;
        public string ownerAddress;
        public decimal balance;
        public Memento(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }

    }
}
