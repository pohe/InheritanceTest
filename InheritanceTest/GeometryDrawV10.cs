using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public  class GeometryDrawV10 : IGeometryDraw
    {
        public void DrawCircle(double x, double y, double radius)
        { }

        public void DrawLine(double x1, double y1, double x2, double y2)
        { }
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        { }

        private int _centrum; 
        public int Centrum { get
            {
                return _centrum;
            }
            set { _centrum = value;  } }

    }
}
