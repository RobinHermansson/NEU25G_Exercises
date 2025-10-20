
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=================================================\n" +
               "\nHello, select a number from the below list: \n" +
               "\n1. Declare a Delegate" +
               "\n2. Use a generic delegate" +
               "\n3. New method that uses a delegate as in-parameter" +
               "\n4. Print the sum of two values" +
               "\n5. Return sum of two values" +
               "\n6. Lambda as an argument" +
               "\n7. Modify printout with lambda" +
               "\n8. Filter an array (printout)" +
               "\n9. Filter any array (to new array)" +
               "\n=================================================\n");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    FullNameCombiner<string, string> delegateCombiner = FullNameCombinerMethod;

                    var fullName = delegateCombiner.Invoke("Robin", "Hermansson");
                    Console.WriteLine(fullName);
                    break;
                case 2:
                    Func<string, string, string> genericDelegate = FullNameCombinerMethod;
                    var genericFullName = genericDelegate.Invoke("Robin", "Hermansson");
                    Console.WriteLine(genericFullName);
                    break;
                case 3:
                    MethodWithFunc(OtherFullNameCombinerMethod);
                    break;
                case 4:

                    Action<int, int> genericDelegatePrintSum = (x, y) =>
                    {
                         Console.WriteLine($"{x} + {y} = {x + y}");
                    };

                    genericDelegatePrintSum.Invoke(2, 3);
                    break;
                case 5:
                    Func<int, int, string> genericDelegateSum = (x, y) =>
                    {
                        return $"{x} + {y} = {x + y}";
                    };
                    Console.WriteLine(genericDelegateSum.Invoke(5,5));
                    break;
                case 6:
                    MethodWithFunc((s, s2) =>
                    {
                        return $"firstName has {s.Length} letters\nlastName has {s2.Length} letters.";
                    });
                    break;
                case 7:
                    string[] cities = { "Gothenburg", "Paris", "Cape town", "Las Vegas" };
                    PrintArrayToConsole(cities, (s1) =>
                    {
                        return s1.ToUpper();
                    });
                    PrintArrayToConsole(cities, (s1) => 
                    {
                        return s1.Substring(0,3);
                    });
                    PrintArrayToConsole(cities, (s1) =>
                    {
                        return s1.Length.ToString();
                    });
                    break;
                case 8:
                    int[] numbersArray = { -20, 1, 2, 3, -99, 10, 11, 15, 29, 39, 120, 60, 4 };
                    Console.WriteLine("All positive numbers: ");
                    NumberArrayPrinter(numbersArray, x =>
                    {
                        if (x > 0)
                        {
                            return true;
                        }
                        return false;
                    });
                    Console.WriteLine("All numbers between 10 and 20: ");
                    NumberArrayPrinter(numbersArray, x =>
                    {
                        if (x >= 10 && x <= 20)
                        {
                            return true;
                        }
                        return false;
                    });
                    Console.WriteLine("\nAll even numbers: ");
                    NumberArrayPrinter(numbersArray, x =>
                    {
                        if (x % 2 == 0)
                        {
                            return true;
                        }
                        return false;
                    });
                    break;
                case 9:
                    int[] numbersArrayTwo = { -20, 1, 2, 3, -99, 10, 11, 15, 29, 39, 120, 60, 4 };
                    Console.WriteLine("All positive numbers: ");
                    int[] foundNumbers = NumberArrayReturnFound(numbersArrayTwo, x =>
                    {
                        if (x > 0)
                        {
                            return true;
                        }
                        return false;
                    });
                    Console.WriteLine("All numbers between 10 and 20: ");
                    int[] foundNumbers2 = NumberArrayReturnFound(numbersArrayTwo, x =>
                    {
                        if (x >= 10 && x <= 20)
                        {
                            return true;
                        }
                        return false;
                    });
                    Console.WriteLine("\nAll even numbers: ");
                    int[] foundNumbers3 = NumberArrayReturnFound(numbersArrayTwo, x =>
                    {
                        if (x % 2 == 0)
                        {
                            return true;
                        }
                        return false;
                    });
                    Console.WriteLine($"Found numbers 1:");
                    foreach (var integer in foundNumbers)
                    {
                        Console.WriteLine(integer);
                    }
                    Console.WriteLine($"\nFound numbers 2:");
                    foreach (var integer2 in foundNumbers2)
                    {
                        Console.WriteLine(integer2);
                    }
                    Console.WriteLine($"\nFound numbers 3:");
                    foreach (var integer3 in foundNumbers3)
                    {
                        Console.WriteLine(integer3);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }
        static string FullNameCombinerMethod(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        static string OtherFullNameCombinerMethod(string firstName, string lastName)
        {
            return $"firstName: {firstName}\nlastName: {lastName}";
        }

        static void MethodWithFunc(Func<string, string, string> myFunc) 
        {
           Console.WriteLine(myFunc.Invoke("Kalle", "Larsson"));
           Console.WriteLine(myFunc.Invoke("Fredrik", "Isaksson"));
           Console.WriteLine(myFunc.Invoke("Peter", "Kvist"));
        }

        static void PrintArrayToConsole(string[] stringArray, Func<string, string> modifier)
        {
            foreach (string singleString in stringArray)
            {
                Console.WriteLine(modifier.Invoke(singleString));
            }
        }

        static void NumberArrayPrinter(int[] intArray, Func<int, bool> finder)
        {
            foreach (var number in intArray)
            {
                if (finder.Invoke(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static int[] NumberArrayReturnFound(int[] intArray, Func<int, bool> finder)
        {
            List<int> tempList = new List<int>();
            foreach (var number in intArray)
            {
                if (finder.Invoke(number))
                {
                    tempList.Add(number);
                }
            }
            return tempList.ToArray();
        }

    }
}
public delegate string FullNameCombiner<T1, T2>(T1 s, T2 s2);


