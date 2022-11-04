using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    interface IGeometryDraw // Et interface er en kontrakt
    {
        public int Centrum { get; set; }
        void DrawCircle(double x, double y, double radius);
        void DrawLine(double x1, double y1, double x2, double y2);
        void DrawRectangle(double x1, double y1, double x2, double y2);
    }

}
