using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemoExtract
{
    class Triangle
    {
        public string Color { get; set; } = "red";
        public long Radius { get; set; } = 1;

        public void DisplayShape()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
