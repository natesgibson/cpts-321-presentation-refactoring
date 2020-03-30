namespace ShapesProgram
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class ShapesHandler
    {
        List<object> shapes;

        public ShapesHandler()
        {
            this.shapes = new List<object>();
        }

        // Gets the total area of the shapes collection
        public double GetTotalArea()
        {
            throw new NotImplementedException();
        }
        
        // Parse all the shapes in the CSV-formatted text
        public void ParseShapes(TextReader text)
        {
            throw new NotImplementedException();
        }
    }
}