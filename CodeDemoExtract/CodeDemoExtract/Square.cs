using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemoExtract
{
    class Square
    {
        public string Color { get; set; } = "blue";
        public long Height { get; set; } = 1;
        public long Width { get; set; } = 1;

        public void DisplayShape()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
