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
                   "\n2. Insert your name and it will be printed" +
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
                        //PrintNameWithReturnValue();
                        break;
                    case 3:
                        //StringLengthLongerThanX();
                        break;
                    case 4:
                        //CelsiusToFarenheit();
                        break;
                    case 5:
                        //AddDashesToInput();
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
    }
}
