namespace Generics {
    internal class Pair<T> : Pair<T, T> {//generisk
        public Pair(T first, T second) : base(first, second) {
        }
    }

    internal class Pair<T1, T2> {
        public T1 First { get; set; }//När get och set saknas är det fält
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second) {
            First = first;
            Second = second;
        }
    }
}