using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn3 {

    class PersonHandler {
        private List<Person> persons;

        public PersonHandler() {
            persons = new List<Person>();
        }

        public void SetAge(Person pers, int age) { pers.Age = age; }
        public void SetFname(Person pers, string name) { pers.ForName = name; }
        public void SetLname(Person pers, string lname) { pers.LastName = lname; }
        public void SetHeight(Person pers, double height) { pers.Height = height; }
        public void SetWeight(Person pers, double weight) { pers.Weight = weight; }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            return new Person(age, fname, lname, height, weight);
        }

        public void ChangePersonAt(int index, int Age, string FName, string LName, 
            int Height, int Weight) {
            persons.ElementAt(index).Age = Age;
            persons.ElementAt(index).ForName = FName;
            persons.ElementAt(index).LastName = LName;
            persons.ElementAt(index).Height = Height;
            persons.ElementAt(index).Weight = Weight;
        }

        public void Add(int age, string fname, string lname, double height, double weight) {
            persons.Add(CreatePerson(age, fname, lname, height, weight));
        }

        public void ListPersons() {
            Console.WriteLine("Befintlig Person:" + persons.Count());
            int c = 0;
            foreach(var e in persons) {
                Console.WriteLine("({0}) {1}", c, e);
                c++;
            }
        }



        /**********     User-input specifika metoder        *************/

        public void NewPersonInput() {// Skapar ny person med userinput
            string inputFname;
            string inputLname;
            int inputAge;
            double inputHeight;
            double inputWeight;

            Console.WriteLine("\nÅlder:");
            do {
                inputAge = CastStringToInt(Console.ReadLine());
            } while(inputAge < 0);

            inputFname = getNames("Förnamn");
            inputLname = getNames("Efternamn");

            inputHeight = getDouble("Längd");
            inputWeight = getDouble("Vikt");

            persons.Add(CreatePerson(inputAge, inputFname, inputLname, inputHeight, inputWeight));
        }

        private double getDouble(string Message) {
            Console.WriteLine(Message);
            double value;
            do {
                value = CastStringToDouble(Console.ReadLine());
            } while(value < 0);
            return value;
        }

        private string getNames(string message) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while(String.IsNullOrWhiteSpace(input)) {
                Console.WriteLine(message + " kan inte lämnas tomt");
                input = Console.ReadLine();
            }
            return input;
        }

        internal void RemovePerson(int input) {
            persons.RemoveAt(input);
        }
        internal void ChangePerson(int input) {
            Console.Clear();
            Console.WriteLine("Du har valt att ändra pers på index nr " + input + " " + persons.ElementAt(input));
            Console.WriteLine("Ny Ålder:");
            int inputAge = CastStringToInt(Console.ReadLine());

            string inputFname = getNames("Nytt förnamn");
            string inputLname = getNames("Nytt fternamn");

            double inputHeight = getDouble("Ny längd");
            double inputWeight = getDouble("Ny Vikt");


            //if-satserna ändrar endast de fält som inte lämnats tomt
            if(inputAge != -1) {
                persons.ElementAt(input).Age = inputAge;
            }
            if(!String.IsNullOrWhiteSpace(inputFname)) {
                persons.ElementAt(input).ForName = inputFname;

            }
            if(!String.IsNullOrWhiteSpace(inputLname)) {
                persons.ElementAt(input).LastName = inputLname;

            }
            if(inputHeight != -1) {
                persons.ElementAt(input).Height = inputHeight;
            }
            if(inputWeight != -1) {
                persons.ElementAt(input).Weight = inputWeight;
            }
        }

        internal int Length() {
            return persons.Count;
        }


        public int CastStringToInt(string input) {
            int stringToInt = -1;
            
            try {
                stringToInt = Convert.ToInt32(input);
            } catch(FormatException) {
                Console.WriteLine("VG ange heltal i siffror :");
            }
            return stringToInt;
        }

        /// <summary>
        /// Tar string och returnerar double
        /// Byter ut eventuell punkt(.) till komma(,) och konverterar sedan
        /// </summary>
        public double CastStringToDouble(string input) {
            double testDouble = -1;
            //           testDouble = Convert.ToDouble(input);

            try {
                input = input.Replace('.', ',');
                testDouble = Convert.ToDouble(input);
            } catch(FormatException) {
                Console.WriteLine("VG ange tal i siffror :");
            }
            return testDouble;
        }
    }
}

