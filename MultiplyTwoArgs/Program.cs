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
