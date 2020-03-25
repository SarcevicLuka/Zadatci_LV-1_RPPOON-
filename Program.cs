using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_LV1_RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoNote FirstNote = new ToDoNote();
            ToDoNote SecondNote = new ToDoNote("Do the dishes","Luka Sarcevic",1);
            ToDoNote ThirdNote = new ToDoNote("Study programming","Katarina Tutic");

            Console.WriteLine("Note: " + FirstNote.getNote() + ", " + "Author: " + FirstNote.getAuthor() + ", " + "Importance: " + FirstNote.getImportance());
            Console.WriteLine("Note: " + SecondNote.getNote() + ", " + "Author: " + SecondNote.getAuthor() + ", " + "Importance: " + SecondNote.getImportance());
            Console.WriteLine("Note: " + ThirdNote.getNote() + ", " + "Author: " + ThirdNote.getAuthor() + ", " + "Importance: " + ThirdNote.getImportance());
            Console.WriteLine(FirstNote.ToString());
            Console.WriteLine(SecondNote.ToString());
            Console.WriteLine(ThirdNote.ToString());
        }
    }
}
