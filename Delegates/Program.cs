
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
            Func<string, string, string> delegateCombiner = FullNameCombiner;

            var fullName = delegateCombiner.Invoke("Robin", "Hermansson");
            Console.WriteLine(fullName);
            break;
        case 2:
            break;
        case 3:
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




static string FullNameCombiner(string firstName,string lastName) 
{
    return $"{firstName} {lastName}";
}