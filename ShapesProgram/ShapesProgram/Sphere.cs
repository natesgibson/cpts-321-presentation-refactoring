namespace ShapesProgram
{
    internal class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double GetSurfaceArea()
        {
            return 4 * 3.1415926535897931d * (this.radius * this.radius);
        }
    }
}