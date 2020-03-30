namespace ShapesProgram
{
    using System.Collections.Generic;
    using System.IO;

    internal class ShapesHandler
    {
        List<object> shapes;

        public ShapesHandler()
        {
            this.shapes = new List<object>();
        }

        // Gets the total surface area of all Cubes in shapes collection
        public double GetTotalCubeSurfaceArea()
        {
            double sumSurfaceAreas = 0.0d;
            foreach (object shape in shapes)
            {
                if (shape is Cube cube)
                {
                    sumSurfaceAreas += cube.GetSurfaceArea();
                }
            }

            return sumSurfaceAreas;
        }

        // Gets the total surface area of all Spheres in shapes collection
        public double GetTotalSphereSurfaceArea()
        {
            double sumSurfaceAreas = 0.0d;
            foreach (object shape in shapes)
            {
                if (shape is Sphere sphere)
                {
                    sumSurfaceAreas += sphere.GetSurfaceArea();
                }
            }

            return sumSurfaceAreas;
        }

        // Gets the total surface area of all Rectangular Prisms in shapes collection
        public double GetTotalRectangularPrismSurfaceArea()
        {
            double sumSurfaceAreas = 0.0d;
            foreach (object shape in shapes)
            {
                if (shape is RectangularPrism prism)
                {
                    sumSurfaceAreas += prism.GetSurfaceArea();
                }
            }

            return sumSurfaceAreas;
        }

        // Parse all the shapes in the CSV-formatted text
        public void ParseShapes(TextReader text)
        {
            string textString = text.ReadToEnd();
            string[] shapesDataString = textString.Split('\n');
            
            foreach (string shapeDataString in shapesDataString)
            {
                string[] shapeData = shapeDataString.Split(',');

                if (shapeData.Length > 0)
                {
                    string name = shapeData[0];
                    
                    switch (name)
                    {
                        case "cube":
                            int sideLength;

                            if (int.TryParse(shapeData[1], out sideLength))
                            {
                                Cube cube = new Cube(sideLength);
                                shapes.Add(cube);
                            }

                            break;
                        case "sphere":
                            int radius;

                            if (int.TryParse(shapeData[1], out radius))
                            {
                                Sphere sphere = new Sphere(radius);
                                shapes.Add(sphere);
                            }

                            break;
                        case "rectangular_prism":
                            int length;
                            int width;
                            int height;

                            bool isLengthValid = int.TryParse(shapeData[1], out length);
                            bool isWidthValid = int.TryParse(shapeData[2], out width);
                            bool isHeightValid = int.TryParse(shapeData[3], out height);

                            if (isLengthValid && isWidthValid && isHeightValid)
                            {
                                RectangularPrism prism = new RectangularPrism(length, width, height);
                                shapes.Add(prism);
                            }

                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}