namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=================================================\n" +
                    "\nHello, select a number from the below list: \n" +
                    "\n1. Print 20 to 30" +
                    "\n2. Print all even numbers" +
                    "\n3. Every third write 'Hey'" +
                    "\n4. 'Times table'" +
                    "\n5. Sum of all numbers up to 1000" +
                    "\n6. Checkboard rice?!" +
                    "\n7. Generate a box of X'es." +
                    "\n8. Generate a box alternating X'es and O's" +
                    "\n9. Make an 'Actual' checkers board." +
                    "\n10. Generate a box that is 'Empty' in the middle with edges" +
                    "\n11. Make a number's pyramid." +
                    "\n12. Create 9 different pyramids." +
                    "\n13. Prime numbers." +
                    "\n14. Guess the number." +
                    "\n15. Rock, Paper, Scissors.\n" +
                    "\n=================================================\n");

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Print20to30();
                        break;
                    case 2:
                        PrintWholeNumbers();
                        break;
                    case 3:
                        EveryThirdHey();
                        break;
                    case 4:
                        MultiplicationsTable();
                        break;
                    case 5:
                        PrintAllNumbersCombinedBetween1to1000();
                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    case 11:

                        break;
                    case 12:

                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;


                }

            }
        }
        static void Print20to30()
        {
            // Exercise goal:
            // * Print 20 to 30.
            Console.WriteLine("\nPrinting 20 to 30.");

            for (int i = 20; i <= 30; i++)
            {
                Console.WriteLine(i); 
            }
            Console.WriteLine("Fin. Press Enter key to continue");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void PrintWholeNumbers()
        {
            // Exercise goall:
            // Print whole numbers, i.e. 2, 4, 8, etc.

            Console.WriteLine("\nWill be printing all whole numbers: ");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fin. Press Enter key to continue");
            Console.WriteLine();
            Console.ReadLine();        
        }

        static void EveryThirdHey()
        {
            // Exercise goal:
            // Write every item divisible by three as 'hey'.

            Console.WriteLine("Will write every third iteration as 'hey'.");

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("hey!");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Fin. Press Enter key to continue");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void MultiplicationsTable()
        {
            // Exercise goal:
            // Query the user for an int
            // Print that number's multiplication's table, i.e. if user inserts 2:  1 * 2, 2 *2, etc.
            Console.WriteLine("Please give me a number and I'll give you the multiplication of it up to 10.");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {userInput} = {i * userInput}");
            }

            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();

        }

        static void PrintAllNumbersCombinedBetween1to1000()
        {
            //Exercise goal:
            // Write all numbers between 1 to 1000 and what they combine to, e.g. 1 to 4  would be 1+2+3+4 = 10

            Console.WriteLine("Not yet implemented");
        }
    }
}
