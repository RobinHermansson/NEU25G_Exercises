namespace Inheritence
{
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(Brand brand, string model, Color color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
        public override string ToString()
        {
            return $"A {Color} {Size.Length:F1} meter long {Model} from {Brand}";
        }
    }
}
