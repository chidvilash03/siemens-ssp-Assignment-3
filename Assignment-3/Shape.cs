using System;

namespace ShapeSpace
{
    interface IDrawable
    {
        public void draw();
    }

    //interface shape
    interface IShape : IDrawable
    {
        //methods
        double getArea();
        double getPerimeter();
    }

    //class circle inherited from interface shape
    class Circle : IShape
    {
        //field
        public double radius;
        //constructor
        public Circle(double radius)
        {
            this.radius = radius; 
        }

        //method to find the area of the circle
        public double getArea()
        {
            return 3.14 * radius * radius;
        }

        //method to find the perimeter of the circle
        public double getPerimeter()
        {
            return 2 * 3.14 * radius;
        }

        public void draw()
        {
            Console.WriteLine("The Circle drawn with radius : " + radius);
        }
    }

    //rectangle class inherited from interface shape
    class Rectangle : IShape
    {
        //fields
        public double length;
        public double breadth;

        //constructors
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        //method to calculate area
        public double getArea()
        {
            return length* breadth;
        } 

        //method to calculate perimeter
        public double getPerimeter()
        {
            return 2 * (length+ breadth);
        }

        public void draw()
        {
            Console.WriteLine("The rectangle is drawn with length " + length + " and breadth " +  breadth);
        }
    }
}
