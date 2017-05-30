using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics {
    static class Utils {
        public static T Clamp<T>(T value, T min, T max) where T : IComparable {
            var lower = Max(value, min);
            var result = Min(lower, max);
            return result;
        }

        //CompareTo returnerar -1,0,1 för < = >
        private static T Max<T>(T v1, T v2) where T : IComparable {
            if(v1.CompareTo(v2) < 0) return v2;
            return v1;
        }

        private static T Min<T>(T v1, T v2) where T : IComparable
            => v1.CompareTo(v2) > 0 ? v2 : v1; //Om v1.CompareTo(v2) är större än 0 returnera v2, annars returnera v1.

        /// Trinäroperator
        /// p?r1:r2
        /// om p returnera r1 annars r2
        ///
        /// unäroperator tex ++ och ==
        /// resten binär


    }

}
