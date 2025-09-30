
using Inheritence;

while (true) 
{
    Console.WriteLine("Select any of the given Exercise options " +
        "\n1. Create a class for vehicles" +
        "\n2. Create an override for String()" +
        "\n3. Create a subclass for Cars" +
        "\n4. Create a struct to store length, width and height" +
        "\n5. Initialize Vehicle and print Car" +
        "\n6. Circles inheriting from Shape" +
        "\n7. Squares also inheriting from Shape" +
        "\n8. Adding Print() to Shapes" +
        "\n9. An array of circles and squares" +
        "\n10. Static print methods" +
        "\n11. Colorize 'PrintAll()'" +
        "\n12. Random colors"
        );

    int selection = int.Parse(Console.ReadLine());

    switch (selection)
    {
        case 1:
            Console.WriteLine("No printout needed, as the exercise was focused on the setup/creation of classes.");
            break;
        case 2:
            Vehicle myVehicleDefaultColor = new Vehicle(Brand.Toyota);
            Vehicle myVehicleBrandAndColor = new Vehicle(Brand.Kia, Color.Black);
            Console.WriteLine(myVehicleDefaultColor);
            Console.WriteLine(myVehicleBrandAndColor);
            break;
        case 3:
            Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
            break;
        case 4:
            break;
        case 5:
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
        case 12:
            break;
        default:
            break;
                 
    }
}


