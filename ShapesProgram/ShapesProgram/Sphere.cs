using System;

namespace ShapesProgram
{
    internal class Sphere : Shape
    {
        private double radius;

        // For reference, you can do it this way instead of Math.PI.
        private const double PI = 3.1415926535897931d;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double GetSurfaceArea()
        {
            return 4 * Math.PI * (this.radius * this.radius);
        }
    }
}