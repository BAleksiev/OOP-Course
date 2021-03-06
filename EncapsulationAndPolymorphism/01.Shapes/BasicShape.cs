﻿namespace Shapes
{
    abstract class BasicShape : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}