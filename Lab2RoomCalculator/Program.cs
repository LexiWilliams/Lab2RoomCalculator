using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgramAgain = true;

            while (runProgramAgain)
            {
                Console.WriteLine("What is the width of the room?");
                float width = float.Parse(Console.ReadLine());

                Console.WriteLine("What is the length of the room?");
                float length = float.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                float height = float.Parse(Console.ReadLine());

                float area = width * length;
                float perimeter = (2 * width) + (2 * length);
                float volume = (width * length * height);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                bool repeat1 = true;

                while (repeat1)
                {
                    Console.WriteLine("Would you like to measure another room? y/n");
                    string runAgain = Console.ReadLine().ToLower();

                    if (runAgain == "y")
                    {
                        repeat1 = false;
                        runProgramAgain = true;
                    }
                    else if (runAgain == "n")
                    {
                        repeat1 = false;
                        runProgramAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("User input was not understood.");
                        repeat1 = true;

                    }
                }
            }

            Console.ReadKey();
        }
    }
}