using System;

namespace CollectionsPracticeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CollectionsClass getMethod = new CollectionsClass();
            getMethod.Queue();
            Console.WriteLine("");
            getMethod.Set();
            Console.WriteLine("");
            getMethod.Dictionary();
            Console.WriteLine("");
            getMethod.List();
            Console.WriteLine("");
            getMethod.Stack();
            Console.WriteLine("");
        }
    }
}