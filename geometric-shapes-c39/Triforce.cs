using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39;
    internal class Triforce {

    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }


    public int Perimeter() {
        return Side1 + Side2 + Side3;
    }

    public Triforce() { }
    
    public Triforce(int side1, int side2, int side3) {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }



}
