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
            return 6 * (this.sideLength * this.sideLength);
        }       
    }
}