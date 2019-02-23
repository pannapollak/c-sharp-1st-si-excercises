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
        }
    }
}
