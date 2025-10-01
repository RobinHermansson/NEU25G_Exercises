namespace Inheritence
{
    public class Square : Shape
    {
        public double SideLength { get; }
        public override double Area => SideLength * SideLength ;
        public override double Circumference => 4 * SideLength;

        public Square (double sideLength)
        {
            SideLength = sideLength;
        }
        public override string ToString()
        {
            return $"A Square with side {SideLength}";
        }
    }
}
