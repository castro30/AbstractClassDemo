using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        abstract class Shape
        {
            public abstract void Draw();
        }
        class Circle : Shape
        {
            public override void Draw()
            {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        class Triangle : Shape
        {
            public override void Draw()
            {
                // draw triangle...
                Console.WriteLine("Triangle Draw");
            }
        }



        static void Main(string[] args)
        {

            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();

            Shape t = new Triangle();
            t.Draw();

            Console.WriteLine(" What shape do you want to draw? Circle, Rectangle, or Triangle");
            string artistsChoice = Console.ReadLine();

            if (artistsChoice == "Triangle")
            {
                t.Draw();
            }
            else if (artistsChoice == "Circle")
            {
                c.Draw();
            }
            else if (artistsChoice == "Rectangle")
            {
                r.Draw();
            }
            else Console.WriteLine("Please try again");

            Console.ReadKey();
        }
    }
}
