namespace ShapesProgram
{
    internal class Square
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double GetArea()
        {
            return (this.sideLength * this.sideLength);
        }       
    }
}