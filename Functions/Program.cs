namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=================================================\n" +
                   "\nHello, select a number from the below list: \n" +
                   "\n1. Print the name 'Robin Hermansson'" +
                   "\n2. Prints the name (as a return value)" +
                   "\n3. Insert a string and then a value, checks if the string is as long as the inserted value." +
                   "\n4. Convert Celsius to Fahrenheit" +
                   "\n5. Add a dash (-) between each letter inserted" +
                   "\n6. Will join each word with a ->" +
                   "\n7. Calculates the median value of the inserted integers" +
                   "\n8. Takes a numbers and returns the text version of those numbers" +
                   "\n9. Takes a full number value (up to the 9999) and converts it to string representation" +
                   "\n10. Finds the index of a given character and returns it (the first occurrence)" +
                   "\n11. Throws dice." +
                   "\n12. Draws a box" +
                   "\n13. Move an '@'-sign with arrow keys." +
                   "\n14. 'The worm', " +
                   "\n=================================================\n");

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        PrintName("Robin", "Hermansson");
                        break;
                    case 2:
                        Console.WriteLine(PrintNameAsReturnValue("Robin Hermansson"));
                        break;
                    case 3:
                        Console.Write("Give me a string and then give me a number and I'll check if the string is longer than your given number.\nLets start with the string: ");
                        string stringToCheck = Console.ReadLine();
                        Console.Write("Now the number: ");
                        int lengthToCheck = int.Parse(Console.ReadLine());
                        if (StringLengthLongerThanX(stringToCheck, lengthToCheck))
                        {
                            Console.WriteLine("Its longer!");
                        }
                        else
                        {
                            Console.WriteLine("It's shorter!");
                        }
                            ;
                        break;
                    case 4:
                        double value = 35.0;
                        double result = CelsiusToFarenheit(value);
                        Console.WriteLine($"the Celcius value of {value} is {result} in Farenheit.");
                        break;
                    case 5:
                        string dashesResult = AddDashesToInput("teststring");
                        Console.WriteLine(dashesResult);
                        break;
                    case 6:
                        //SelfMadeStringJoin();
                        break;
                    case 7:
                        //CalcMedianvalue();
                        break;
                    case 8:
                        //NumbersToText();
                        break;
                    case 9:
                        //FullNumbersToText();
                        break;
                    case 10:
                        //FindIndexOf();
                        break;
                    case 11:
                        //ThrowDice();
                        break;
                    case 12:
                        //DrawBox();
                        break;
                    case 13:
                        //MoveAnAtSignWithArrows();
                        break;
                    case 14:
                        //TheWorm();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;

                }

            }
        }
        static void PrintName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        static string PrintNameAsReturnValue(string userInput)
        {
            return $"{userInput}";
        }

        static bool StringLengthLongerThanX(string stringToCheck, int lengthToCheck)
        {
            bool result = false;

            if (stringToCheck.Length > lengthToCheck)
            {
                return result;
            }
            return result;

        }

        static double CelsiusToFarenheit(double value)
        {           
            return (value*1.8) + 32;
        }

        static string AddDashesToInput(string inputString)
        {
            string finalResult = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == 0)
                {
                    finalResult += inputString[i];
                }
                else
                {
                    finalResult += $"-{inputString[i]}";
                }
            }
            return finalResult;
        }
    }
}
