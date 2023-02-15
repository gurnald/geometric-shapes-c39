using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class MathLib
    {

        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Subtract(int x, int y) {
            return x - y;
        }
        public static int Multiply(int x, int y) { 
            return x * y; 
        }
        public static int Divide(int x, int y) {
            if (y == 0) {
                Console.WriteLine("Cannot divide by zero!");
                return -1;
            } 
                return x / y; 
        }

    }

}