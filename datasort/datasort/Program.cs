using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datasort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D.A.T.A. S.O.R.T. 5001 initialized, press enter to begin.");
            Console.ReadLine();
            Console.WriteLine("SORTING begun, how many numbers would you like to sort?");
            int size = Convert.ToInt32(Console.ReadLine());
            List<string> numberos = new List<string>();
            Stack<string> numbers = new Stack<string>();
            for (int i = 0; i<= size; i++)
            {
                Console.WriteLine("Enter value number " + i + ".");
                string num = Console.ReadLine();
                numberos.Add(num);
                numbers.Push(num);
            }
            Console.WriteLine("Press Enter to sort values.");
            Console.ReadLine();
            Console.WriteLine("Stored Values:");
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine("Element " + i + " : " + numberos[i] + ".");
            }
            Console.WriteLine("Values sorted in reverse order:");
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine("Element " + i + " : " + numbers.Pop() + ".");
            }
            Console.ReadLine();

            /*
             Storing directions for traps

             Queue<Directions> trapGuide = new Queue<Directions>();

            Directions to store :East->South->East->East->North->North->North->West->North->North->East->East->East->South->East
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.South);
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.North);
            trapGuide.Enqueue(Directions.North);
            trapGuide.Enqueue(Directions.North);
            trapGuide.Enqueue(Directions.West;
            trapGuide.Enqueue(Directions.North);
            trapGuide.Enqueue(Directions.North);
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.East);
            trapGuide.Enqueue(Directions.South);
            trapGuide.Enqueue(Directions.East);

                public enum Directions
        {
            North, East, South, West
        }*/

            
         

        }
    }
}
