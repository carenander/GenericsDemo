using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kodexempel för max
            /*
            Console.WriteLine(Max(1, 2).GetType().Name);
            Console.WriteLine(Max(1.2, 2.4).GetType().Name);
            Console.WriteLine(Max(Math.Floor(-4.3f), Math.Floor(-1.2f)));
            Console.WriteLine(Max("Anders", "Bengt"));
            */
            #endregion

            var intPair = new Pair<int>(1, 2);
            Console.WriteLine(intPair);

            var stringPair = new Pair<string>("a", "b");
            Console.WriteLine(stringPair);

            var dualPair = new Pair<int, float>(1, 2.4f);
            Console.WriteLine(dualPair);

            var intStringPair = new Pair<int, string>(7, "seven");
            Console.WriteLine(intStringPair);

            var pairPair = new Pair<    Pair<int>,    Pair<string>   >(intPair, stringPair);
            Console.WriteLine(pairPair);
        }

        private static T Max<T>(T a, T b) where T : IComparable
        {       
            if (a.CompareTo(b) > 0) return a;
            return b;
        }
    }
}
