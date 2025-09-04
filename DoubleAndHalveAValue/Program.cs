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
