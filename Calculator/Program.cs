// Excercise goal:
// * Query the user for a value
// * Query for an operator (+, -, *, /)
// * Query for the last value
// * Calculate the first and second value using the selected operator

Console.WriteLine("Hello there! Welcome to Calculator2000.");
Console.WriteLine("Give me one value, then give me the operator and then your final value.");
Console.Write("First value: ");
int firstValue = int.Parse(Console.ReadLine());
Console.Write("Second value: ");
int secondValue = int.Parse(Console.ReadLine());
int result;
Console.Write("Operator: (+, -, *, /) ");
string userOperator = Console.ReadLine();
switch (userOperator)
{
    case "+":
        result = firstValue + secondValue;
        break;
    case "-":
        result = firstValue - secondValue;
        break;
    case "*":
        result = firstValue * secondValue;
        break;
    case "/":
        result = firstValue / secondValue;
        break;
    default:
        Console.WriteLine("I were not able to find your written operator... please write - for substractions etc.");
        result = 0;
        break;
}
if (result == 0)
{
    Console.WriteLine("Something seems to have gone awry.");
}
else
{
    Console.WriteLine($"Here is the calculation and result {firstValue} {userOperator} {secondValue} = {result}");
}