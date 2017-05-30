using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling {
    class PersonHandler {
        private List<Person> persons = new List<Person>();
        public void SetAge(Person pers, int age) {
            pers.Age = age;
        }
        public void SetFname(Person pers, string name) {
            pers.ForName = name;
        }
        public void SetLname(Person pers, string lname) {
            pers.LastName = lname;
        }
        public void SetHeight(Person pers, double height) { pers.Height = height; }
        public void SetWeight(Person pers, double weight) { pers.Weight = weight; }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            var p = new Person(age, fname, lname, height, weight);
            return p;
        }
        public Person CreatePerson(string fname, string lname) {
            var p = new Person(fname, lname);
            return p;
        }
        public void AddPerson(string fname, string lname) {
            var Person = new Person(fname, lname);
            persons.Add(Person);
        }
        public void AddPerson(Person pers) {
            persons.Add(pers);
        }
        public void ListPersons() {
            Console.WriteLine("Personer:");
            int c = 0;
            foreach(var e in persons) {
                Console.WriteLine("{1}", c, e);
                c++;
            }
        }
    }
}
