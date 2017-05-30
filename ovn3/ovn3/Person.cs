using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn3 {
    /// <summary>
    /// 
    /// </summary>

    class Person {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age { get { return age; } set { age = value; } }
        public string ForName { get { return fName; } set { fName = value; } }
        public string LastName { get { return lName; } set { lName = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public Person() { }
        public Person(int Age, string fname, string lname) : this(Age, fname, lname, 0, 0) { }
        public Person(string fname, string lname) : this(-1, fname, lname, 0, 0) { }
        public Person(int Age, string FName, string LName, double Height, double Weight) {
            age = Age;
            fName = FName;
            lName = LName;
            height = Height;
            weight = Weight;
        }

        public override string ToString() {
            return (age + " år " + fName + " " + lName + " " + height + "cm " + weight + "kg");
        }
    }
}
