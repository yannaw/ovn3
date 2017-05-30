using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person();
            Console.WriteLine(p1);
            Console.WriteLine();
            PersonHandler ph = new PersonHandler();
            Person p = ph.CreatePerson(111,"aaa", "bbb", 1.1, 1.2);
            ph.AddPerson(p);
            Person q = ph.CreatePerson("ccc", "ddd");
            ph.AddPerson(q);



            ph.ListPersons();
        }
    }
}
