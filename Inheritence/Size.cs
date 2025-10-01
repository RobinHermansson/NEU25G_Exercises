namespace Inheritence
{
    public struct Size
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Length { get; set; }

        public Size(double length, double width, double height)
        {

            Length = length;
            Width = width;
            Height = height;

        }
    }
}
