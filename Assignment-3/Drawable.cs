using System;
using ShapeSpace;
namespace DrawableSpace
{
    interface IDrawable
    {
        void Draw(string shape);
    }

    interface IShape : IDrawable
    {
        public void Draw(string shape)
        {
            Console.WriteLine("The shape Drawn is : " +  shape);
        }
    }
}

