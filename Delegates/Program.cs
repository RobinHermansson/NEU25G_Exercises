
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
                   // FullNameCombiner<string, string> delegateCombiner = FullNameCombinerMethod;

                    //var fullName = delegateCombiner.Invoke("Robin", "Hermansson");
                    //Console.WriteLine(fullName);
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
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
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
    }
}
public delegate string OtherFullNameCombiner<T1, T2>(T1 s, T2 s2);


