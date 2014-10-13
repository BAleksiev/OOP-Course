using System;

namespace Shapes
{
    class Triangle : BasicShape
    {
        private double a;
        private double b;
        private double c;
        private double p;

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.p = (this.A + this.B + this.C) / 2;
        }

        public double A
        {
            get { return this.a; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Write positive number");
                }
                this.a = value;
            }
        }

        public double B
        {
            get { return this.b; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Write positive number");
                }
                this.b = value;
            }
        }

        public double C
        {
            get { return this.c; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Write positive number");
                }
                this.c = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(this.p * (this.p - this.A) * (this.p - this.B) * (this.p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return this.p * 2;
        }
    }
}
