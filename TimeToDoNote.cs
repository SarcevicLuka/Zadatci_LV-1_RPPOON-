using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_LV1_RPPOON
{
    class TimeToDoNote : ToDoNote
    {
        private DateTime time;

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public TimeToDoNote():base()
        {
            this.time = DateTime.Now;
        }
        public TimeToDoNote(string note, string author, int importance,DateTime time) : base(note, author, importance)
        {
            this.time = time;
        }

        public override string ToString()
        {
            return base.ToString()+", Time:" + this.time;
        }
    }
}
