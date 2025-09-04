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
