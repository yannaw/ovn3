using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn3 {
    class Program {
        static void Main(string[] args) {

            PersonHandler persons = new PersonHandler(); ;

            //Lägger till personer
            persons.Add(1, "A", "A", 1, 1);
            persons.Add(2, "B", "B", 2, 2);
            persons.ListPersons();
            Console.WriteLine();

            persons.ChangePersonAt(0, 9, "9", "9", 9, 9); //Ändrar uppgifter på person på position 0
            Console.WriteLine("\nEfter Ändring:");
            persons.ListPersons();

            persons.RemovePerson(0); //Raderar objekt på position 0
            Console.WriteLine("\nEfter radering:");
            persons.ListPersons();


            /// 3.1.1   
            ///Person p1 = new Person(111, "aaa", "bbb", 1.1, 1.2);
            /// Det går inte att komma åt variablerna direkt då de är private däremot via properies.
            /// Console.WriteLine(p1.fName); 
            /// Console.WriteLine(p1.ForName);

            /*
            /// 3.1.2
            PersonHandler ph = new PersonHandler();
            Person p2 = ph.CreatePerson();
            ph.AddPerson(p2);

            Person p3 = ph.CreatePerson("ccc", "ddd");
            ph.AddPerson(p3);

            // ph.ListPersons();


            /********************************************************************************************************/

            ///    3.2
            Console.WriteLine("\n\nDjur:");

            var animalList = new List<Animal>();
            animalList.Add(new Animal());
            animalList.Add(new Horse(200));
            animalList.Add(new Dog("Svart"));
            animalList.Add(new Hedgehog(345));
            animalList.Add(new Worm("Hav"));
            animalList.Add(new Bird(34));
 
            int c = 0;
            foreach(var e in animalList) {
                Console.WriteLine("{1}", c, e);
                c++;
            }

            var doglList = new List<Dog>();
            doglList.Add(new Dog("Röd"));
            //           doglList.Add(new Horse(100)); //Kan ej casta häst till dog

            var birdList = new List<Bird>();
            birdList.Add(new Pelican("Sven"));
            birdList.Add(new Flamingo(7));
            birdList.Add(new Swan(16));

            Console.WriteLine("\nFågellista");
            c = 0;
            foreach(var e in birdList) {
                Console.WriteLine("{1}", c, e);

            }


            /********************************************************************************************************/

            // 3.3
            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new ProgramInputError());
            errors.Add(new CatInputError());
            errors.Add(new SleepInputError());

            Console.WriteLine("\n\n");
            int d = 0;
            foreach(var e in errors) {
                Console.WriteLine("{1}", d, e.UEMessage());
                d++;
            }

            Console.WriteLine();
 
        }

    }
}
