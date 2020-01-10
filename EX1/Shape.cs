using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Shape
    {
        public string Color
        {
            get;
            set;
        }
        public Shape(string c = "") { Color = c; }
        public string getColor() { return Color; }
        public void setColor(string c) { Color = c; }
        public virtual double getPerimeter() { return 0; }
    }

    class Circle : Shape
    {
        int radius;
        public Circle(int r = 0, string c = "") : base(c) { radius = r; }
        public int getRadius() { return radius; }
        public void setRadius(int r) { radius = r; }
        public double getPerimeter()
        {
            return 3.1415 * radius * radius;
        }
    }

    class EqPolygon : Shape
    {
        public int SideLen
        {
            get;
            set;
        }

        public EqPolygon(int len = 0, string c = "") : base(c) { SideLen = len; }

        public virtual double getPerimeter() { return 0; }
    }

    class Triangle : EqPolygon
    {
        public Triangle(int len = 0, string c = "") : base(len, c) { }
        public double getPerimeter() { return 3 * SideLen; }
    }

    class Square : EqPolygon
    {
        public Square(int len = 0, string c = "") : base(len, c) { }
        public double getPerimeter() { return 4 * SideLen; }
    }

    class Pentagon : EqPolygon
    {
        public Pentagon(int len = 0, string c = "") : base(len, c) { }
        public double getPerimeter() { return 5 * SideLen; }
    }
}
