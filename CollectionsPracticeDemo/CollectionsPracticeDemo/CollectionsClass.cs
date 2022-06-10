using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPracticeDemo
{
    public class CollectionsClass
    {
        public void Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Madhavi");
            queue.Enqueue("Sahil");
            queue.Enqueue("Anil");
            queue.Enqueue("Nandini");
            queue.Enqueue("Shreyash");

            Console.WriteLine("Data available in Queue:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nHead: " + queue.Peek());
            string deQueue = queue.Dequeue();
            Console.WriteLine("\nDequeue First Element:" + deQueue);
            Console.WriteLine("\nData available in Queue after removing one Element:");

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void Set()
        {
            var set = new HashSet<string>();
            set.Add("Madhavi");
            set.Add("Sahil");
            set.Add("Anil");
            set.Add("Nandini");
            set.Add("Shreyash");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            Console.WriteLine("Data available in Hashset:");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Madhavi");
            dictionary.Add(2, "Sahil");
            dictionary.Add(3, "Anil");
            dictionary.Add(4, "Nandini");
            dictionary.Add(5, "Shreyash");
            Console.WriteLine("Accessing Data using Key: " + dictionary[1]);
            Console.WriteLine("Data available in Dictionary: ");
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + "\tValue: " + kvp.Value);
            }
        }
        public void List()
        {
            List<string> list = new List<string>();
            list.Add("Madhavi");
            list.Add("sahil");
            list.Add("Anil");
            list.Add("Nandini");
            list.Add("Shreyash");
            Console.WriteLine("Data available in List:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Madhavi");
            stack.Push("Sahil");
            stack.Push("Anil");
            stack.Push("Nandini");
            stack.Push("Shreyash");

            Console.WriteLine("Data availabe in Stack: ");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("Last Data in the Stack: " + stack.Peek());
            string pop = stack.Pop();
            Console.WriteLine("Data " + pop + " Poped from Stack");
            Console.WriteLine("Data availabe after Poping one element from Stack: ");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}