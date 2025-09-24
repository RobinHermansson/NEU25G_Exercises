
using Properties;

while (true) 
{
    Console.WriteLine("Select any of the given Exercise options " +
        "\n1. Person with Property FirstName" +
        "\n2. Autoproperty LastName" +
        "\n3. Read-only property FirstName" +
        "\n4. Steps calculator" +
        "\n5. Car" +
        "\n6. Glas o' water" +
        "\n7. Blue and Red" +
        "\n8. Temperature" +
        "\n9. Car 2" +
        "\n10. Adding a static method" +
        "\n11. Simulation"
        );

    int selection = int.Parse(Console.ReadLine());

    switch (selection) 
    {
        case 1:
            Person myPerson = new Person();
            myPerson.FirstName = "Lars";

            Console.WriteLine($"Here is myPerson's FirstName, through a public Property: {myPerson.FirstName}");
            Console.WriteLine();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            break;
        case 11:
            break;
        default:
            Console.WriteLine($"Your inserted value ({selection}) was not valid. Try again.");
            break;
                 
    }
}
