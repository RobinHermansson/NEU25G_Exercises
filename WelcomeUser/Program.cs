// Exercise goal:
// TO CONSOLE
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
