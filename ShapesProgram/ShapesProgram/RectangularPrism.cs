namespace ShapesProgram
{
    internal class RectangularPrism
    {
        private double length;

        private double width;

        private double height;

        public RectangularPrism(double length, double width, double height)
        {
            this.length = length;

            this.width = width;

            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * ((this.width * this.length) + (this.height * this.length) + (this.height * this.width));
        }
    }
}