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
                        Calculator();
                        break;
                    case 7:
                        ReverseOrder();
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
            static void Calculator() 
            {
                Console.WriteLine("Please give me a calculation to perform, on one line, e.g. '34 + 49'");
                string userInput = Console.ReadLine();

                
                int firstNumbers;
                int secondNumbers;
                string firstNumbersAsString = string.Empty;
                string secondNumbersAsString = string.Empty;
                char operatorType = ' ';
                int finalResult = -1;

                List<char> allowedOperators = ['-', '+', '*', '/'];

                //Will loop through each character in the string to discern the type, instead of splitting it on each space
                //in order to learn this 'proper'.
                for (int i = 0; i < userInput.Length; i++)
                { 
                
                    if (userInput[i] != ' ' || allowedOperators.Contains(userInput[i]))
                    {
                        if (allowedOperators.Contains(userInput[i]))
                        {
                            operatorType = userInput[i];
                        }
                        if (operatorType == ' ' && !allowedOperators.Contains(userInput[i]))
                        {
                            firstNumbersAsString += userInput[i]; 
                        }
                        else if (operatorType != ' ' && !allowedOperators.Contains(userInput[i]))
                        {
                            secondNumbersAsString += userInput[i];
                        }
                    }
                }

                int.TryParse(firstNumbersAsString, out firstNumbers);
                int.TryParse(secondNumbersAsString, out secondNumbers);

                if (operatorType == '+')
                {
                    finalResult = firstNumbers + secondNumbers;

                }
                else if (operatorType == '-')
                {
                    finalResult = firstNumbers - secondNumbers;
                }
                else if (operatorType == '*')
                {
                    finalResult = firstNumbers * secondNumbers;
                }
                else if (operatorType == '/')
                {
                    finalResult = firstNumbers / secondNumbers;
                }
                else
                {
                    Console.WriteLine("Could not decipher what kind of Operator you wanted to use... try any of these: +-*/");
                }
                if (finalResult != -1)
                {
                    Console.WriteLine($"{firstNumbers} {operatorType} {secondNumbers} = {finalResult}");
                }
                
            }
            static void ReverseOrder() 
            {

                string[] userTotalInput = new string[7];
                int totalInputs = 0;
                int stopAt = 7;
                Console.WriteLine("Write a total of 7 things, and I will print the items in reverse order I got them. ");
                while (totalInputs != 7)
                {
                    Console.WriteLine($"Write {stopAt - totalInputs } more inputs please. (write the letter q to quit.)");
                    string userInput = Console.ReadLine();
                    if (userInput == "q")
                    {
                        Console.WriteLine("\n----------\nDecided to quit, huh? If not: Try again and do not write just the letter 'q' as you will quit then.");
                        break;
                    }
                    if (userInput.Length != 0 && userInput != "q")
                    {
                        userTotalInput[totalInputs] = userInput;
                        totalInputs += 1;
                    }
                    else
                    {
                        Console.WriteLine("You did not seem to insert anything...");
                        
                    }                   
                }
                
                if (totalInputs == 7)
                {
                    Console.WriteLine("\n----------\nHere are your items in reversed order! Fun.");
                    for (int i = userTotalInput.Length -1; i >= 0; i--)
                    {
                        Console.WriteLine(userTotalInput[i]);
                    }

                }
                


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
