using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console  
//using static då Console man inte är intresserad av att instansiera Console's alla klasser.

namespace Generics {
    class Program {
        static void Main(string[] args) {

            /*            Console.WriteLine(Utils.Clamp(1, 2, 4).GetType().Name);
                        Console.WriteLine(Utils.Clamp(3, 2.0, 4).GetType().Name);
                        Console.WriteLine(Utils.Clamp(7, 2, 4.1).GetType().Name);

                        Console.WriteLine(1.2.ToString(CultureInfo.InvariantCulture));
            */

            var isoPair = new Pair<bool>(true, false);//<int> typargument för att ange typ 
            var first = isoPair.First;
            var second = isoPair.Second;
            Console.WriteLine($"pair: [{first}, {second}]");//Tar en sträng där måsvingar tolkas som C#

            var pair = new Pair<int, string>(5, "hej");
            Console.WriteLine($"pair: [{pair.First}, {pair.Second}]");//Tar en sträng där måsvingar tolkas som C#

        }
    }
}
