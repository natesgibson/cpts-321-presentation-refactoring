namespace ShapesProgram
{
    using System;
    using System.IO;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapesHandler shapesHandler = new ShapesHandler();

            using (FileStream file = new FileStream("shapes_data.csv", FileMode.Open, FileAccess.Read))
            {
                shapesHandler.ParseShapes(new StreamReader(file));

                Console.WriteLine("Sum of surface area of all cubes: " + shapesHandler.GetTotalCubeSurfaceArea());
                Console.WriteLine("Sum of surface area of all spheres: " + shapesHandler.GetTotalSphereSurfaceArea());
                Console.WriteLine("Sum of surface area of all rectangular prisms: " + shapesHandler.GetTotalRectangularPrismSurfaceArea());
            }
        }
    }
}