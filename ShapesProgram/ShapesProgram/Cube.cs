namespace ShapesProgram
{
    internal class Cube
    {
        private double sideLength;

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double GetSurfaceArea()
        {
            double areaOfOneSurface = this.sideLength ^ 2;
            return 6 * areaOfOneSurface;
        }       
    }
}