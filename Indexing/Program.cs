namespace Indexing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("====================================\n" +
                    "Select one of the numbered options below: " +
                    "\n1. Print one letter on each row" +
                    "\n2. Print the letter representation of a number" +
                    "\n3. Print the inserted text backwards." +
                    "\n4. Hide any vowels." +
                    "\n5. Palindrom." +
                    "\n6. Calculator." +
                    "\n7. Reversed order." +
                    "\n8. Delayed printout." +
                    "\n9. Letters pyramid." +
                    "\n10. Colored letters." +
                    "\n11. Start and stop." +
                    "\n12. Change colors.\n" +
                    "====================================\n");
                
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        OneLetterOnEachRow();
                        break;
                    case 2:
                        NumberToLetterRepresentation();
                        break;
                    case 3:
                        WriteStringBackwards();
                        break;
                    case 4:
                        HideVowels();
                        break;
                    case 5:
                        PalindromOrNot();
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
                        Console.WriteLine("That is not a valid selection. Try again.");
                        break;
                    }
            }

            static void OneLetterOnEachRow() 
            {

                Console.WriteLine("Please write some letters and I will print them on separate rows.");
                string? userLetters = Console.ReadLine();

                for (int i = 0; i < userLetters.Length; i++)
                {
                    Console.WriteLine(userLetters[i]);
                }

                Console.WriteLine();

            }

            static void NumberToLetterRepresentation()
            {
                Console.WriteLine("Please write a number, and I'll give you the text representation.");
                int userInput = int.Parse(Console.ReadLine());

                string[] possibleNumberRepresentations = new string[]
                {
                    "noll",
                    "ett",
                    "två",
                    "tre",
                    "fyra",
                    "fem",
                    "sex",
                    "sju",
                    "åtta",
                    "nio",
                    "tio"
                };

                Console.WriteLine($"Here is the letter-representation: {possibleNumberRepresentations[userInput]}");
                Console.WriteLine();
            }
            static void WriteStringBackwards() 
            {

                Console.WriteLine("Please give me a string and I'll write it backwards");
                string userInsertedString = Console.ReadLine();

                for (int i = userInsertedString.Length - 1; i >= 0; i--) 
                {
                    Console.Write(userInsertedString[i]);
                }
                Console.WriteLine();

            }

            static void HideVowels() 
            {
                List<char> listOfVowels = ['a', 'e', 'i', 'o', 'u', 'y'];

                Console.WriteLine("Please give me a string and I will hide all vowels.");
                string userInput = Console.ReadLine();
                string myNewString = string.Empty;

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (listOfVowels.Contains(userInput[i]))
                    {
                        myNewString += "*";

                    }
                    else 
                    {
                        myNewString += userInput[i];
                    }
                }


                Console.WriteLine($"Here is your new string:\n{myNewString}");

            }
            static void PalindromOrNot() 
            {

                Console.WriteLine("Please give me a word and I'll check if it is a Palindrome (Same forwards as backwards)");
                string userInput = Console.ReadLine().ToLower();
                string palindromized = string.Empty;

                for (int i = userInput.Length - 1; i >= 0; i--) 
                {
                    palindromized += userInput[i];
                }

                if (userInput == palindromized)
                {
                    Console.WriteLine($"That is a palindrome!\n{userInput}\n{palindromized}");
                }
                else 
                {
                    Console.WriteLine($"That is NOT a palindrome...\n{userInput}\n{palindromized}");
                }



            }
            static void Calculator(string letters) 
            { 

            }
            static void ReverseOrder(string letters) 
            { 

            }
            static void DelayedPrintout(string letters) 
            { 

            }
            static void LettersPyramid(string letters) 
            { 

            }
            static void ColorizedLetters(string letters) 
            { 

            }

            static void StartAndStop(string letters)
            { 
            }


        }
    }
}
