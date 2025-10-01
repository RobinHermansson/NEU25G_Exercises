namespace Inheritence
{
    public class Vehicle
    {
        public Brand Brand { get; set; }
        public Color Color { get; set; }

        public Size Size { get; }
        public Vehicle()
        {
            var randomSelectionBrand = new Random().Next(0, 5);
            var randomSelectionColor = new Random().Next(0, 5);

            var randomLength = (new Random().NextDouble() * 4.0) + 1.0;
            var randomWidth = (new Random().NextDouble() * 1.0) + 1.0;
            var randomHeight = (new Random().NextDouble() * 1.0) + 1.0;
            Brand = (Brand)randomSelectionBrand;
            Color = (Color)randomSelectionColor;
            Size = new Size(randomLength, randomWidth, randomHeight);

        }
        public Vehicle(Brand brand, Color color)
        {
            Brand = brand;
            Color = color;
            Size = new Size(4.1, 2.3, 1.9);
        }

        public Vehicle(Brand brand)
        {
            Brand = brand;
            Color = Color.Gold;
            Size = new Size(4.1, 2.3, 1.9);
        }

        public override string ToString()
        {
            return $"This vehicle is a {Color} {Brand}, the size is: L/W/H: {Size.Length:F1} / {Size.Width:F1} / {Size.Height:F1}";
        }
    }
}
