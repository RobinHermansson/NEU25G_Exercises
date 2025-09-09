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
                    "\n8. Generate a box alternating X'es and O's in a 'Striped' pattern" +
                    "\n9. Make an 'Actual' chess board." +
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
                        ChessboardRice();
                        break;
                    case 7:
                        PrintAFilledBox();
                        break;
                    case 8:
                        PrintAStripedBox();
                        break;
                    case 9:
                        PrintACheckeredBox();
                        break;
                    case 10:
                        PrintAnEmptyBox();
                        break;
                    case 11:
                        CreateANumbersPyramid();
                        break;
                    case 12:
                        CreateNineNumbersPyramids();
                        break;
                    case 13:
                        PrimeNumbers();
                        break;
                    case 14:
                        GuessTheNumber();
                        break;
                    case 15:
                        RockPaperScissors();
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
            // Write all numbers combined 1 to 1000 and what they combine to, e.g. 1 to 4  would be 1+2+3+4 = 10

            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum = i + sum;
                Console.Write($"{i}+");
                if (sum >= 1000) break;
            }
            Console.WriteLine($"={sum}");
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void ChessboardRice() 
        {
            //Exercise goal:
            // For each field in a chessboard (64 fields) double the amount of rice on each subsequent field.
    
            ulong fieldAmount = 1; // necessary to use ulong otherwise the value will overflow
            
            for (int i = 1; i <= 64; i++) 
            {
                Console.WriteLine($"Field {i}: {fieldAmount}");
                fieldAmount *= 2;

            }
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();
        }
        static void PrintAFilledBox() 
        {
            // Exercice goal:
            // Query the user for the "height" and the "Width" of a box and print the 2 dimensional box out using X:s

            Console.Write("Please give me your wanted 'Height' of the box: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Thanks! Now give me the 'Width', please: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"You gave me the following Height and Width: {height}, {width}");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();

        }

        static void PrintAStripedBox() 
        {
            // Exercise goal:
            // Query the user for the "height" and the "Width" of a box and print the 2 dimensional box out using X:s and O:s alternating to create a striped.

            Console.Write("Please give me your wanted 'Height' of the box: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Thanks! Now give me the 'Width', please: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"You gave me the following Height and Width: {height}, {width}");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();

        }

        static void PrintACheckeredBox() 
        {
            // Exercise goal:
            // Query the user for the "height" and the "Width" of a box and print the 2 dimensional box out using X:s and O:s alternating to create a checkered look.

            Console.Write("Please give me your wanted 'Height' of the box: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Thanks! Now give me the 'Width', please: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"You gave me the following Height and Width: {height}, {width}");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();

        }
        static void PrintAnEmptyBox() 
        {
            // Exercise goal:
            // Query the user for the "height" and the "Width" of a box and print the 2 dimensional box out using X:s and O:s alternating to create a checkered look.

            Console.Write("Please give me your wanted 'Height' of the box: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Thanks! Now give me the 'Width', please: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"You gave me the following Height and Width: {height}, {width}");
            
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height-1 || j == 0 || j == width-1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Fin! Press Enter key to continue.");
            Console.WriteLine();
            Console.ReadLine();

        }

        static void CreateANumbersPyramid()
        {
            // Exercise goal:
            // Create a numbers pyramids, like so:
            // 1
            // 12
            // 123
            // 1234
            // 12345
            // 123456
            // etc.


            Console.WriteLine("Here comes the pyaramid.\n");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }

        static void CreateNineNumbersPyramids()
        {
            // Exercise goal:
            // Create 9 different numbers pyramids, start with 1, then 1,2 and then 1,2,3 like so:
            // 1
            //
            // 1
            // 12
            //
            // 1
            // 12
            // 123
            // etc.

            Console.WriteLine("Pyramids bonanza: ");

            int maxPyramids = 10;
            int currentHeight = 1;
            while (currentHeight != maxPyramids)
            {
                for (int i = 0; i <= currentHeight; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                currentHeight++;

            }
  
        }
        static void PrimeNumbers()
        {
            // Exercise goal:
            // Get all prime numbers (Divisible with itself but which are not divisble by any other full numbers before it stopping at 1.).

            
           Console.WriteLine("Here comes the 20 first Prime numbers: ");
    
            int count = 0;
            int number = 2;
            
            while (count < 20)
            {
                bool isPrime = true;
                
                // Check if number is divisible by any smaller number (except 1)
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                {
                    Console.WriteLine(number);
                    count++;
                }
                
                number++;
            }
        }
        static void GuessTheNumber()
        {
            var rand = new Random();
            int secretNumber = rand.Next(100);

            Console.WriteLine($"The computer will guess the secret number: {secretNumber}"); 

            int computerChoice = rand.Next(1, 100);
            int highestGuess = computerChoice;
            int lowestGuess = computerChoice;
            int highestPossible = 100;
            int lowestPossible = 1;

            Console.WriteLine($"My first guess will be {computerChoice}");

            while (true)
            {
                
                if (computerChoice == secretNumber)
                {
                    Console.WriteLine($"You win! Secret number was {secretNumber}");
                    break;
                }
                if (computerChoice > secretNumber)
                {
                    Console.WriteLine("Too high!");
                    if (highestPossible >= computerChoice)
                    {
                        highestPossible = computerChoice;
                        if (highestPossible < highestGuess)
                        {
                            highestGuess = highestPossible;
                        }
                        computerChoice = rand.Next(lowestPossible, highestPossible);
                    }
                    else
                    {
                        computerChoice = rand.Next(lowestGuess, highestPossible);
                    }
                        
                    Console.WriteLine($"New choice: {computerChoice}");
                }
                else
                {
                    Console.WriteLine("Too low!");
                    if (lowestPossible <= computerChoice)
                    {
                        lowestPossible = computerChoice;
                        if (lowestGuess > lowestPossible) {
                            lowestGuess = lowestPossible;
                        }
                        computerChoice = rand.Next(lowestPossible, highestPossible);
                    }
                    else { 
                        computerChoice = rand.Next(lowestPossible, highestGuess);
                    }


                    Console.WriteLine($"New choice: {computerChoice}");

                }
            }
        }
        static void RockPaperScissors() 
        {  
            Dictionary<string, string> winCons = new Dictionary<string, string>();
            string rockWins = "scissors";
            string scissorsWins = "paper";
            string paperWins = "rock";

            Dictionary<string, string> loseCons = new Dictionary<string, string>();
            string paperLoses = "scissors";
            string scissorsLoses = "rock";
            string rockLoses = "paper";

            winCons["rock"] = rockWins;
            winCons["scissors"] = scissorsWins;
            winCons["paper"] = paperWins;

            string userSelection = "";
            List<string> options = new List<string> { "rock", "paper", "scissors" };
            var rand = new Random();
                           
            while (true) 
            {
                Console.WriteLine("Write 'Rock', 'Paper' or 'Scissors'");
                string computerSelection = options[rand.Next(0, 2)];
                userSelection = Console.ReadLine().ToLower();

                if (userSelection.Length == 0)
                {
                    break;
                }
                 
                if (userSelection == computerSelection)
                {
                    Console.WriteLine($"Player: {userSelection}\nComputer: {computerSelection}");
                    Console.WriteLine("EQUAL! Try again!");
                    
                }
                if (winCons[userSelection] == computerSelection) 
                {
                    Console.WriteLine($"User wins! User had: {userSelection}, Computer had: {computerSelection}");
                    Console.WriteLine("Play again? Chooose your battlestance again or press Enter to quit.");
                    
                }
                if (winCons[computerSelection] == userSelection)
                { 
                    Console.WriteLine($"Computer wins! User had: {userSelection}, Computer had: {computerSelection}");
                    Console.WriteLine("Play again? Chooose your battlestance again or press Enter to quit.");
                }

            }
           
        }
    }
}