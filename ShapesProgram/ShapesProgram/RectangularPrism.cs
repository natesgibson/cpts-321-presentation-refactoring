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
            double topAndBottom = 2 * (this.width * this.length);
            double frontAndBack = 2 * (this.height * this.length);
            double leftAndRight = 2 * (this.height * this.width);
            return topAndBottom + frontAndBack +leftAndRight;
        }
    }
}