namespace ShapesProgram
{
    internal class Cube : Shape
    {
        private double sideLength;

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double GetSurfaceArea()
        {
            double areaOfOneSurface = this.sideLength * this.sideLength;
            return 6 * areaOfOneSurface;
        }       
    }
}