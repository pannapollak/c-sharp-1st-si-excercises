using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue randomQueue = new Queue();

            randomQueue.Enqueue("First");
            randomQueue.Enqueue("Second");
            randomQueue.Enqueue("Third");
            randomQueue.Enqueue("Fourth");

            Console.WriteLine("Current queue: ");
            foreach (var element in randomQueue)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine("Count elements: " + randomQueue.Count);
            Console.WriteLine("Is there the word 'Second' in the queue? " + randomQueue.Contains("Second"));
            Console.WriteLine("First element here and removed: " + randomQueue.Dequeue());
            Console.WriteLine("Here is the hash code, watup: " + randomQueue.GetHashCode());
            Console.WriteLine("Type of this instance, as we didn't know: " + randomQueue.GetType());
            Console.WriteLine("Removing the first element, wich is supposedly the 'Second': " + randomQueue.Dequeue());
            Console.WriteLine("not very clean codey, here is a foreach to show the leftovers of this excercise: ");
            foreach (var element in randomQueue)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine("And here is a very useful copy of our queue as an array, enjoy: " + randomQueue.ToArray());
            Console.WriteLine("Let's see the first element, if you forgot: " + randomQueue.Peek());

            Stack randomStack = new Stack();

            randomStack.Push("First");
            randomStack.Push("Second");
            randomStack.Push("Third");
            randomStack.Push("Fourth");



        }
    }
}
