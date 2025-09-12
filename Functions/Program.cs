using System.Transactions;

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
                   "\n7. Calculates the average value of the inserted integers" +
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
                        string stringJoinResult = SelfMadeStringJoin("->", "test", "Another string", "One more", "last one.");
                        Console.WriteLine(stringJoinResult);
                        break;
                    case 7:
                        double averageValue = CalcAverageValue(5, 31, 403, 34444, 299);
                        Console.WriteLine($"Here is the average value of your inserted values: {averageValue}");
                        break;
                    case 8:
                        string[] numbersAsText = NumbersToText(123459);
                        Console.WriteLine($"Here is your digits as a string array and in text: {string.Join(", ", numbersAsText)}");
                        break;
                    case 9:
                        string fullNumbersResult = FullNumbersToText(9999);
                        Console.WriteLine(fullNumbersResult);
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

        static string SelfMadeStringJoin(string separator, params string[] inputArray)
        {
            string finalResult = string.Empty;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 0)
                {
                    finalResult += inputArray[i];
                }
                else
                {
                    finalResult += $"{separator}{inputArray[i]}";
                }
            }
            return finalResult;
        }

        static double CalcAverageValue(params int[] inValues)
        {
            double sum = 0.0;
            for (int i = 0; i < inValues.Length; i++)
            {
                sum += inValues[i];
            }
            double result = (sum / inValues.Length);
            return result;
        }

        static string[] NumbersToText(int numbersToConvert)
        {
            string allNumbersAsString = numbersToConvert.ToString();
            string[] result = new string[allNumbersAsString.Length];

            for (int i = 0; i < allNumbersAsString.Length; i++)
            {
                
                switch (allNumbersAsString[i])
                {
                    case '1':
                        result[i] = "one";
                        break;
                    case '2':
                        result[i] = "two";
                        break;
                    case '3':
                        result[i] = "three";
                        break;
                    case '4':
                        result[i] = "four";
                        break;
                    case '5':
                        result[i] = "five";
                        break;
                    case '6':
                        result[i] = "six";
                        break;
                    case '7':
                        result[i] = "seven";
                        break;
                    case '8':
                        result[i] = "eight";
                        break;
                    case '9':
                        result[i] = "nine";
                        break;

                }
            }
            return result;
        }
        static string FullNumbersToText(int number)
        {
            string result = string.Empty;

            string entireNumberAsString = number.ToString();

            
            if (entireNumberAsString.Length == 4)
            {

            }
            if (entireNumberAsString.Length == 3)
            {

            }
            if (entireNumberAsString.Length == 2)
            {

            }
            if (entireNumberAsString.Length == 1)
            {

            }

            static string Handle1to9(char character)
            {
                switch (character)
                {
                    case '1':
                        return "one";
                    case '2':
                        return "two";
                    case '3':
                        return "three";
                    case '4':
                        return "four";
                    case '5':
                        return "five";
                    case '6':
                        return "six";
                    case '7':
                        return "seven";
                    case '8':
                        return "eight";
                    case '9':
                        return "nine";
                    default:
                        return "";

                }
               
            }

            static string Handle10s(string number)
            {
                if (number[0] == '1')
                {
                    switch (number)
                    {
                        case "10":
                            return "ten";
                        case "11":
                            return "eleven";
                        case "12":
                            return "twelve";
                        case "13":
                            return "thirteen";
                        case "14":
                            return "fourteen";
                        case "15":
                            return "fifteen";
                        case "16":
                            return "sixteen";
                        case "17":
                            return "seventeen";
                        case "18":
                            return "eighteen";
                        case "19":
                            return "nineteen";
                        default:
                            return "COULDNOTHANDLE10-19";
                    }
                }
                if (number[0] == '2')
                {
                    switch (number)
                    {
                        case "20":
                            return "twenty";
                        default:
                            return $"twenty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '3')
                {
                    switch (number)
                    {
                        case "30":
                            return "thirty";
                        default:
                            return $"thirty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '4')
                {
                    switch (number)
                    {
                        case "40":
                            return "fourty";
                        default:
                            return $"fourty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '5')
                {
                    switch (number)
                    {
                        case "50":
                            return "fifty";
                        default:
                            return $"fifty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '6')
                {
                    switch (number)
                    {
                        case "60":
                            return "sixty";
                        default:
                            return $"sixty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '7')
                {
                    switch (number)
                    {
                        case "70":
                            return "seventy";
                        default:
                            return $"seventy{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '8')
                {
                    switch (number)
                    {
                        case "80":
                            return "eightty";
                        default:
                            return $"thirty{Handle1to9(number[1])}";
                        }
                }
                if (number[0] == '9')
                {
                    switch (number)
                    {
                        case "90":
                            return "ninety";
                        default:
                            return $"ninety{Handle1to9(number[1])}";
                        }
                }
                return "Could not handle 10s";
            }
            static string Handle100s(string number)
            {

                return $"{Handle1to9(number[0])} hundred";
            }

            static string Handle1000s(string number)
            {

                return $"{Handle1to9(number[0])} thousand";
            }

            return entireNumberAsString;

        }
    }
}
