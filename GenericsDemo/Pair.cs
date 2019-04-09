﻿namespace GenericsDemo
{
    internal class Pair<T> : Pair<T, T>
    {

        public Pair(T first, T second)
            : base(first, second)
        {
        }
    }

    internal class Pair<T1, T2>
    {
        public T1 First { get; }
        public T2 Second { get; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()
        {
            return $"[{First}, {Second}]";
        }
    }


}