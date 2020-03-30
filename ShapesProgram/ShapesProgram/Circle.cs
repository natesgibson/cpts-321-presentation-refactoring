namespace ShapesProgram
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return 3.1415926535897931d * (this.radius * this.radius);
        }
    }
}