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