using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetVirtualApp
{
    abstract class Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }

        abstract public int DX {  get; set; }

        public Shape() : this(0, 0) { }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }



        abstract public int Area();
        abstract public int Perimetr();
    }

    class Rectangle : Shape
    {
        public int Width {  get; set; }
        public int Height { get; set; }
        
        int dx;
        int dy;
        public override int DX 
        { 
            get => dx;
            set 
            {
                dx = value;
                dy = value;
            }
        }

        public Rectangle() : this(0, 0, 0, 0) { }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return base.ToString() + $", Width: {Width}, Height: {Height}";
        }



        public override int Area()
        {
            return Width * Height;
        }

        public override int Perimetr()
        {
            return 2 * (Width + Height);
        }
    }

    class Circle : Shape
    {
        public int Radius { set; get; }

        int dx;
        public override int DX
        { 
            get => dx;
            set => dx = value * 2;
        }

        public Circle() : this(0, 0, 0) { }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + $", Radius: {Radius}";
        }


        public override int Area()
        {
            return 3 * Radius * Radius;
        }

        public override int Perimetr()
        {
            return 2 * 3 * Radius;
        }
    }
}
