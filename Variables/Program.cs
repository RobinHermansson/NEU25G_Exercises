namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Select any of the given Exercise options " +
                    "\n1. Welcome user" +
                    "\n2. Multiply two arguments" +
                    "\n3. Verify password" +
                    "\n4. Compare values" +
                    "\n5. Double and halve a given value" +
                    "\n6. Calculator" +
                    "\n7. Sum and Average");

                int selection = int.Parse(Console.ReadLine());

                switch (selection) 
                {
                    case 1:
                        WelcomeUser();
                        break;
                    case 2:
                        MultiplyTwoArgs();
                        break;
                    case 3:
                        VerifyPassword();
                        break;
                    case 4:
                        CompareValues();
                        break;
                    case 5:
                        DoubleAndHalveAValue();
                        break;
                    case 6:
                        Calculator();
                        break;
                    case 7:
                        SumAndAverage();
                        break;
                    default:
                        Console.WriteLine($"Your inserted value ({selection}) was not valid. Try again.");
                        break;
                             
                }
            }
        }
        static void WelcomeUser()
        { 
            // Exercise goal:
            // * Prompt the user to write their name
            // * Respond with a welcome phrase with the inserted name.
            // for fun: Added a simple check to not allow 0 length names. Longer than 1 letter is OK ;)

            Console.Write("Hello there! Please write your name: ");

            string name = string.Empty;

            while (name.Length == 0 && name is not null)
            {
                string? userInput = Console.ReadLine();
                if (userInput is not null && userInput.Length != 0)
                {
                    name = userInput;
                    break;
                }
                Console.Write("Please write a valid name: ");
            }

            Console.WriteLine($"Hello {name}!");
        }
        static void MultiplyTwoArgs()
        {
            // Exercise goal:
            // * Query the user for two (2) ints
            // * Multiply these two received ints
            // * Print the results


            Console.WriteLine("Hello! Please give me two numbers. Lets start with the first. Thanks in advance.");
            Console.Write("First value: ");
            string? userFirstInput = Console.ReadLine();

            int acceptedFirstValue = 0;
            while (acceptedFirstValue == 0 || userFirstInput?.Length == 0)
            {
                int number;
                bool success = int.TryParse(userFirstInput, out number);
                if (success && number != 0)
                {
                    acceptedFirstValue = number;
                    Console.WriteLine("Got it. Next please.");
                    break;
                }
                else 
                { 
                    Console.WriteLine("That is not an acceptable number. Could be an empty string or not a number.");
                    Console.Write("Try again: ");
                    userFirstInput = Console.ReadLine();
                }
            }

            Console.Write("Second value: ");
            string? userSecondInput = Console.ReadLine();

            int acceptedSecondValue = 0;
            while (acceptedSecondValue == 0 || userSecondInput?.Length == 0)
            {
                int number;
                bool success = int.TryParse(userSecondInput, out number);
                if (success && number != 0)
                {
                    acceptedSecondValue = number;
                    Console.WriteLine("Got both!");
                    break;
                }
                else 
                { 
                    Console.WriteLine("That is not an acceptable number. Could be an empty string or not a number.");
                    Console.Write("Try again: ");
                    userSecondInput = Console.ReadLine();
                }
            }

            int result = acceptedFirstValue * acceptedSecondValue;
            Console.WriteLine($"Final product is: {acceptedFirstValue} * {acceptedSecondValue} = {result}");
        }

        static void VerifyPassword()
        {
            // Exercise goal:
            // * Query the user to guess a hardcoded password.

            Console.WriteLine("Guess the password: ");
            string correctPass = "123asd";

            string? userGuess = Console.ReadLine();

            while (userGuess != correctPass) 
            {
                Console.Write("Nope. Guess again: ");
                userGuess = Console.ReadLine();
            }

            Console.WriteLine("Woo! Correct."); 
        }
        static void CompareValues() 
        {
            // Exercise goal:
            // * Query the user for a number.
            // * Check if the received number is larger or smaller than 100

            Console.WriteLine("Throw me a number and I'll check if it is larger or smaller than 100.");
            Console.Write("Your number, please: ");


            int userInsertedNumber;
            bool success = int.TryParse(Console.ReadLine(), out userInsertedNumber);
            // Currently no check if it is successful or not.

            if (userInsertedNumber < 100)
            {
                Console.WriteLine($"Your inserted number ({userInsertedNumber}) is less than 100!");
            }
            else {
                Console.WriteLine($"Your inserted number ({userInsertedNumber}) is larger than 100!");
            }
        }
        static void DoubleAndHalveAValue()
        { 
            // Exercise goal:
            // * Query the user for a value
            // * Multiply the received value by 2
            // * Divide the received value by 2
            // * Print the result

            Console.WriteLine("Please give me a value, and I'll multiply and divide it by 2.");
            Console.Write("Value: ");

            int userNumber;
            while (true)
            {
                string? userAttempt = Console.ReadLine();
                if (!IsValidDivisibleNumber(userAttempt))
                {
                    Console.WriteLine("That will not work... please insert a number, and do not insert a 0.");
                }
                else 
                {
                    userNumber = int.Parse(userAttempt);
                    break;
                }
            }

            static bool IsValidDivisibleNumber(string? input)
            {
                //Helper function as a test to find numbers that can be divided.
                int number;
                bool success = int.TryParse(input, out number);
                if (!success || number == 0)
                {
                    return false;
                }
                else 
                { 
                    return true;
                }
            }
            double userValueMultipliedByTwo = userNumber * 2;
            double userValueHalved = userNumber / 2.0;

            Console.WriteLine($"Here is your value ({userNumber}) multiplied by two: {userValueMultipliedByTwo} ({userNumber} * 2)");
            Console.WriteLine($"Here is your value ({userNumber}) halved in two: {userValueHalved} ({userNumber} / 2)");
        
        }
        static void Calculator()
        {
            // Excercise goal:
            // * Query the user for a value
            // * Query for an operator (+, -, *, /)
            // * Query for the last value
            // * Calculate the first and second value using the selected operator

            Console.WriteLine("Hello there! Welcome to Calculator2000.");
            Console.WriteLine("Give me one value, then give me the operator and then your final value.");
            Console.Write("First value: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Second value: ");
            int secondValue = int.Parse(Console.ReadLine());
            int result;
            Console.Write("Operator: (+, -, *, /) ");
            string userOperator = Console.ReadLine();
            switch (userOperator)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
                default:
                    Console.WriteLine("I were not able to find your written operator... please write - for substractions etc.");
                    result = 0;
                    break;
            }
            if (result == 0)
            {
                Console.WriteLine("Something seems to have gone awry.");
            }
            else
            {
                Console.WriteLine($"Here is the calculation and result {firstValue} {userOperator} {secondValue} = {result}");
            }
        }

        static void SumAndAverage()
        {
            
            // Exercise goal:
            // * Query the user for a number
            // * If the user writes a number again, keep adding it (to a list perhaps).
            // * When user does not insert a number, consider it done and print the average of all values.
            List<int> listOfNumbersFromUser = new();
            Console.WriteLine("Hello, Write some numbers, and I will then combine them to make an average. FUN!");
            while (true)
            {
                Console.Write("Insert: ");
                string? userNumber = Console.ReadLine();
                int number;
                bool success = int.TryParse(userNumber, out number);
                if (success && number != 0)
                {
                    listOfNumbersFromUser.Add(number);
                    Console.WriteLine("More numbers?");
                    Console.WriteLine("Currently we have: ");
                    foreach (int listitem in listOfNumbersFromUser)
                    {
                        Console.WriteLine(listitem);
                    }
                }
                else {

                    break;
                } 
            }
            int total = 0;
            foreach (int number in listOfNumbersFromUser)
            {
                total = total + number;
            }
            Console.WriteLine("Lets calculate some, eh?");
            Console.WriteLine($"Total numbers: {listOfNumbersFromUser.Count} Combined value {total} and the average is {total / listOfNumbersFromUser.Count}! Fascinating.");
        }
    }
}
