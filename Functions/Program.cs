using System.Data;
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
                        string fullNumbersResult = FullNumbersToText(9);
                        Console.WriteLine(fullNumbersResult);
                        break;
                    case 10:
                        int[] indexes = FindIndexOf("Hello world", 'o');
                        Console.WriteLine(string.Join(", ", indexes));
                        break;
                    case 11:
                        int[] diceRolls = ThrowDice(12);
                        Console.WriteLine($"The dice rolled: {string.Join(", ", diceRolls)}");
                        break;
                    case 12:
                        DrawBox(7, 4);
                        break;
                    case 13:
                        MoveAnAtSignWithArrows();
                        break;
                    case 14:
                        TheWorm(rows: 5, columns: 12, numberOfObstacles: 1);
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
                string thousands = Handle1000s(entireNumberAsString);
                string plusHundreds = Handle100s(entireNumberAsString[1..]);
                string tens = Handle10s(entireNumberAsString[2..]);

                string thousandsPlusHundreds = $"{thousands}  {plusHundreds}";
                string thousandsPlusHundredsPlusTens = $"{thousandsPlusHundreds} {tens}";
                string fullString = thousandsPlusHundredsPlusTens;



                Console.WriteLine(fullString);
            }
            if (entireNumberAsString.Length == 3)
            {
                string hundreds = Handle100s(entireNumberAsString);
                string tens = Handle10s(entireNumberAsString[1..]);
                string fullString = $"{hundreds} {tens}";
                Console.WriteLine(fullString);

            }
            if (entireNumberAsString.Length == 2)
            {
                string fullString = Handle10s(entireNumberAsString);
                Console.WriteLine(fullString);
            }
            if (entireNumberAsString.Length == 1)
            {   
                string fullString = Handle1to9(entireNumberAsString[0]);
                Console.WriteLine(fullString);
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
        static int[] FindIndexOf(string stringToCheck, char charToFind)
        {

            byte charAppearances = 0;
            for (byte i = 0; i < stringToCheck.Length; i++)
            { 
                if (stringToCheck[i] == charToFind)
                {
                    charAppearances += 1;
                }
                
            }
            int[] allAppearences = new int[charAppearances]; // this is to attempt to save allocated memory
            byte addedToArray = 0;

            for (byte i = 0; i < stringToCheck.Length; i++)
            { 
                if (stringToCheck[i] == charToFind)
                {
                    allAppearences[addedToArray] = i;
                    addedToArray++;

                }
                
            }

            return allAppearences;

        }

        static int[] ThrowDice(int howMany)
        {
            int[] finalResult = ThrowManyDice(howMany);

            static int[] ThrowManyDice(int howMany)
            {
                Random diceRandom = new Random();

                int[] result = new int[howMany];
                byte additions = 0;
                
                for (int i = 1; i <=  howMany; i++)
                {
                    int diceValue = diceRandom.Next(1, 7);
                    result[additions] = diceValue;
                    additions++;
                }
                return result;
            }

            return finalResult;
        }

        static void DrawBox(int height, int width)
        {
            char borderChar = '#';
            char innerChar = '-';

            

            Console.Clear();
            int origRow = Console.CursorTop;
            int origCol = Console.CursorLeft;

            for (int heightI = 0; heightI < height; heightI++)
            {
                for (int borderY = 0; borderY < width; borderY++)
                {
                    if (heightI == 0 || heightI == height-1 || borderY == 0 || borderY == width-1)
                    {
                        WriteAt(borderChar, origRow, origCol, heightI, borderY);
                        //Console.Write(borderChar);
                    }
                    else
                    {
                        WriteAt(innerChar, origRow, origCol, heightI, borderY);
                        //Console.Write(innerChar);
                    }
                }
                Console.WriteLine();
            }

            

        }

        static void MoveAnAtSignWithArrows()
        {
            int boxHeight = 14;
            int boxWidth = 14;

            char borderChar = '#';
            char innerChar = '-';

            char snakeHead = '@';

            int startYPos = boxHeight / 2;
            int startXPos = boxWidth / 2;

            int currentYPos = startYPos;
            int currentXPos = startXPos;
            int nextYPos = currentYPos + 1;
            int nextXPos = currentXPos + 1; 
            int previousYPos;
            int previousXPos;

            Console.Clear();
            Console.CursorVisible = false;
            int origRow = Console.CursorTop;
            int origCol = Console.CursorLeft;

            DrawBox(boxHeight, boxWidth);
            WriteAt(snakeHead, origRow, origCol, startXPos, startYPos);

            while (true)
            {

                var userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (currentYPos -1 != 0) 
                    {
                        previousYPos = currentYPos;
                        currentYPos--;
                        WriteAt(snakeHead, origRow, origCol, currentXPos, currentYPos);
                        WriteAt(innerChar, origRow, origCol, currentXPos, previousYPos);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (userInput.Key == ConsoleKey.DownArrow) 
                {
                    if (currentYPos + 2 != boxHeight)
                    {
                        previousYPos = currentYPos;
                        currentYPos++;
                        WriteAt(snakeHead, origRow, origCol, currentXPos, currentYPos);
                        WriteAt(innerChar, origRow, origCol, currentXPos, previousYPos);
                    }
                    else 
                    {
                        continue;
                    }


                }
                if (userInput.Key == ConsoleKey.LeftArrow) 
                {
                    if (currentXPos -1 != 0)
                    {
                        previousXPos = currentXPos;
                        currentXPos--;
                        WriteAt(snakeHead, origRow, origCol, currentXPos, currentYPos);
                        WriteAt(innerChar, origRow, origCol, previousXPos, currentYPos);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (userInput.Key == ConsoleKey.RightArrow) 
                {
                    if (currentXPos +2 != boxWidth)
                    {
                        previousXPos = currentXPos;
                        currentXPos++;
                        WriteAt(snakeHead, origRow, origCol, currentXPos, currentYPos);
                        WriteAt(innerChar, origRow, origCol, previousXPos, currentYPos);
                    }
                    else
                    {
                        continue;
                    }
                }

                
            }




        }
        static void TheWorm(int rows, int columns, int numberOfObstacles)
        {
            char border = '+';
            char obstacle = '#';
            char snakeHead = '@';

            int startYPos = rows / 2;
            int startXPos = columns / 2;

            char[,] initialState = BoxGenerator(rows, columns, numberOfObstacles);

            initialState[startYPos, startXPos] = snakeHead;

            UpdatedDrawBox(initialState);

            

        }
        // Helper function
        static void WriteAt(char charToWrite, int originalRow, int originalCol, int xcoord, int ycoord) 
        {


            Console.SetCursorPosition(originalCol + xcoord, originalRow + ycoord);
            Console.Write(charToWrite);
        }

        static char[,] BoxGenerator(int rows, int columns, int numberOfObstacles)
        {

            char[,] box = new char[rows, columns];
            char borderChar = '+';
            char innerChar = '-';
            char obstacleChar = '#';

            Random myRand = new();
            
            Console.Clear();
            int origRow = Console.CursorTop;
            int origCol = Console.CursorLeft;

            for (int heightI = 0; heightI < rows; heightI++)
            {
                for (int borderY = 0; borderY < columns; borderY++)
                {
                    if (heightI == 0 || heightI == rows-1 || borderY == 0 || borderY == columns-1)
                    {
                        box[heightI, borderY] = borderChar; 
                    }
                    else
                    {
                        box[heightI, borderY] = innerChar;

                    }   
                }
            }

            // place random obstacles.
            for (int i = 0; i <= numberOfObstacles -1; i++)
            {
                box[myRand.Next(2, rows-1), myRand.Next(2, columns-1)] = obstacleChar; 
            }
            
            
            return box; 



            
            

        }

        static void UpdatedDrawBox(char[,] boxToDraw)
        {
            for (int row = 0; row < boxToDraw.GetLength(0); row++)
            {
                for (int column = 0; column < boxToDraw.GetLength(1); column++)
                {
                    Console.Write(boxToDraw[row, column]);
                }
                Console.WriteLine();
            }

        }

    }
}
