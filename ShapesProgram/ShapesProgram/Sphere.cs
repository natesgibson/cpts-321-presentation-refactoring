namespace ShapesProgram
{
    internal class Sphere
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public double GetSurfaceArea()
        {
            return 4 * 3.1415926535897931d * (this.radius * this.radius);
        }
    }
}