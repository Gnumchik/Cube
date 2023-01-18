using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            Quadrilateral lolo = new Quadrilateral(7, 5, 30);
            Console.WriteLine(lolo.CountArea(7,5,30));
        }
    }

    class Tetragon
    {
        public float a;
        public float b;
        public float angel;

        public Tetragon(float a, float b, float angel)
        {
            this.a = a;
            this.b = b;
            this.angel = angel;
        }

        public virtual float CountPrimeter(float a, float b)
        {
            return 0;
        }



        public virtual double CountArea(float a, float b, float angle)
        {
            return 0;
        }
                

    }


    class Quadrilateral : Tetragon
    {
        public Quadrilateral(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * b * Math.Sin(angle)) / 2;
        }

        public override float CountPrimeter(float a, float b)
        {
            return base.a + base.b + a + b;
        }
    }

    class ConvexQuadrilateral : Tetragon
    {
        public ConvexQuadrilateral(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * b * Math.Sin(angle)) / 2;
        }

        public override float CountPrimeter(float a, float b)
        {
            return base.a + base.b + a + b;
        }
    }

    class parallelogram : Tetragon
    {
        public parallelogram(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * b * Math.Sin(angle)) ;
        }

        public override float CountPrimeter(float a, float b)
        {
            return (a + b)/2;
        }
    }


    class Rhombus : Tetragon
    {
        public Rhombus(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * a ) * Math.Sin(angle);
        }

        public override float CountPrimeter(float a, float b)
        {
            return (a * a * a * a);
        }
    }

    class Rectangle : Tetragon
    {
        public Rectangle(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * b);
        }

        public override float CountPrimeter(float a, float b)
        {
            return (a + b) * 2;
        }
    }


    class Square : Tetragon
    {
        public Square(float a, float b, float angel) : base(a, b, angel)
        {

        }

        public override double CountArea(float a, float b, float angle)
        {
            return (a * a);
        }

        public override float CountPrimeter(float a, float b)
        {
            return (a + a + a + a);
        }
    }
}
