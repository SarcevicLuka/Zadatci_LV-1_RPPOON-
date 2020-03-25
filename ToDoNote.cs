using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_LV1_RPPOON
{
    class ToDoNote
    {
        private string note;
        private string author;
        private int importance;

        public string getNote()
        {
            return this.note;
        }
        public void setNote(string note)
        {
            this.note = note;
        }
        public string getAuthor()
        {
            return this.author;
        }
        private void setAuthor(string author)
        {
            this.author = author;
        }
        public int getImportance()
        {
            return this.importance;
        }
        public void setImportance (int importance)
        {
            this.importance = importance;
        }


        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }
        public int Importance
        {
            get { return this.importance; }
            set { this.importance = value; }
        }
        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }

        public ToDoNote()
        {
            this.note = "This is a note.";
            this.author = "Author";
            this.importance = 0;
        }
        public ToDoNote(string note,string author,int importance)
        {
            this.note = author;
            this.author = author;
            this.importance = importance;
        }
        public ToDoNote(string note,string author)
        {
            this.note = note;
            this.author = author;
            this.importance = 0;
        }

        public override string ToString()
        {
            return "Note: " + this.note + ", " + "Author: " + this.author + ", " + "Importance: " + this.importance;
        }
    }
}
