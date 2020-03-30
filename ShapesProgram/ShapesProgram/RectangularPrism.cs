namespace ShapesProgram
{
    internal class RectangularPrism
    {
        private double length;

        private double width;

        private double height;

        public RectangularPrism(double l, double w, double h)
        {
            this.length = l;

            this.width = w;

            this.height = h;
        }

        public double GetSurfaceArea()
        {
            return 2 * ((this.width * this.length) + (this.height * this.length) + (this.height * this.width));
        }
    }
}