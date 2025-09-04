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