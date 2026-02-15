using System;
using IntSegregationExample.Interfaces;

namespace IntSegregationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Eagle (can eat, walk, and fly) ===");
            var eagle = new Eagle();
            eagle.Eat("a rabbit");
            eagle.Walk(2);
            eagle.Fly(50, 1500);
            eagle.Fly(50, 3000);

            Console.WriteLine();
            Console.WriteLine("=== Penguin (can eat and walk, but NOT fly) ===");
            var penguin = new Penguin();
            penguin.Eat("fish");
            penguin.Walk(5);
            // penguin has no Fly() method — that's ISP in action!
        }
    }
}
