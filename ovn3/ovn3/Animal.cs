using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn3 {

    /// <summary>
    /// 3.2 Arv
    /// 
    /// 12 Vilken typ måste listan lagra? Bird? (Pelican, Flamingo, Swan)
    /// 13 Vilken typ måste listan vara: Bird
    /// 14 Nytt attribut läggs till i närmsta basklass, vilket blir Bird för subklasserna Pelican, Flamingo, Swan 
    /// 15 Globalt attribult läggs till i basklassen dvs i Animal
    /// 
    /// </summary>
    class Animal {
        private int legs;
        private char gender;

        public int Legs => legs;
        public char Gender => gender;

        public Animal() { }
        public Animal(int Legs, char Gender) {
            legs = Legs;
            gender = Gender;
        }
        public Animal(int Legs) : this(Legs, 'u') { }

        public override string ToString() {
            return String.Format("Ben: {0} Kön: {1}", Legs, Gender);
        }
    }

    /**********   Subklasser   ****************************************************/

    class Horse : Animal {
        private int height;

        public int Height {
            get { return height; }
            set { height = value; }
        }

        public Horse(int Height) : base(4, 'F') { height = Height; }

        public override string ToString() {
            return String.Format("Häst: Ben: {0} Kön: {1} Höjd: {2}", Legs, Gender, Height);
        }
    }

    class Dog : Animal {
        private string color;

        public string Color {
            get { return color; }
            set { color = value; }
        }

        public Dog(string Color) : base(4, 'M') { color = Color; }

        public override string ToString() {
            return String.Format("Hund: Ben: {0} Kön: {1} Färg: {2}", Legs, Gender, Color);
        }
    }

    class Hedgehog : Animal {
        private int quill;

        public int Quill { get { return quill; } set { quill = value; } }

        public Hedgehog(int Quill) : base(4, 'u') { quill = Quill; }

        public override string ToString() {
            return String.Format("Igelkott: Ben: {0} Kön: {1} Taggar: {2}", Legs, Gender, Quill);
        }
    }

    class Worm : Animal {
        private string habitat;

        public string Habitat { get { return habitat; } set { habitat = value; } }

        public Worm(string Habitat) : base(0, 'u') { habitat = Habitat; }

        public override string ToString() {
            return String.Format("Orm: Ben: {0} Kön: {1} Miljö: {2}", Legs, Gender, Habitat);
        }
    }

    class Bird : Animal {
        private double weight;

        public double Weight { get { return weight; } set { weight = value; } }

        public Bird() : base(2, 'u') { }

        public Bird(double Weight) : base(2, 'u') { weight = Weight; }

        public override string ToString() {
            return String.Format("Fågel: Ben: {0} Kön: {1} Vikt: {2}", Legs, Gender, Weight);
        }
    }

    /**********   Bird Subklasser   ****************************************************/
    class Pelican : Bird {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        public Pelican(string Name) : base() { name = Name; }

        public override string ToString() {
            return String.Format("Pelikan: Ben: {0} Kön: {1} Vikt: {2} Namn: {3}",
                Legs, Gender, Weight, Name);
        }
    }

    class Flamingo : Bird {
        private int partner;

        public int Partner { get { return partner; } set { partner = value; } }

        public Flamingo(int Partner) : base() { partner = Partner; }

        public override string ToString() {
            return String.Format("Pelikan: Ben: {0} Kön: {1} Vikt: {2} Partners: {3}",
                Legs, Gender, Weight, Partner);
        }
    }

    class Swan : Bird {
        private int kids;

        public int Kids { get { return kids; } set { kids = value; } }

        public Swan(int Kids) : base() { kids = Kids; }

        public override string ToString() {
            return String.Format("Pelikan: Ben: {0} Kön: {1} Vikt: {2} Barn: {3}",
                Legs, Gender, Weight, Kids);
        }
    }
}

