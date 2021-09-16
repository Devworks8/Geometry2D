using System;

namespace Psim.Geometry2D
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get => _x;
            set
            {
                _x = Double.IsNaN(value) ? throw new ArgumentException() : value; // If the value passed is not a number throw an exception
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                _y = Double.IsNaN(value) ? throw new ArgumentException() : value; // If the value passed is not a number throw an exception
            }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        
        /// <summary>
        /// Instantiate Point class with predefined X and Y coordinates
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        public Point(double? x, double? y)
        {
            X = x ?? throw new ArgumentNullException();
            Y = y ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Set X and Y coordinates
        /// Retain old value if argument passed is null
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetCoords(double? x, double? y)
        {
            X = x ?? X;
            Y = y ?? Y;
        }

        /// <summary>
        /// Get X and Y coordinates
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        public void GetCoords( out double x, out double y)
        {
            x = X;
            y = Y;
        }
    }

    public class Vector
    {
        private double _dx;
        private double _dy;

        public double DX
        {
            get => _dx;
            set
            {
                _dx = Double.IsNaN(value) ? throw new ArgumentException() : value; // If the value passed is not a number throw an exception 
            }
        }

        public double DY
        {
            get => _dy;
            set
            {
                _dy = Double.IsNaN(value) ? throw new ArgumentException() : value; // If the value passed is not a number throw an exception
            }
        }

        public Vector()
        {

        }

        public Vector(double? dx = 0, double? dy = 0)
        {
            DX = SanityCheck(dx);
            DY = SanityCheck(dy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dx">X Vector</param>
        /// <param name="dy">Y Vector</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw exception if dx or yx is not in +-1 range or if it's null </exception>
        public void Set(double? dx, double? dy)
        {
            DX = SanityCheck(dx);
            DY = SanityCheck(dy);
        }

        private double SanityCheck(double? dv)
        {
            return dv < -1 || dv > 1 ? throw new ArgumentOutOfRangeException() : dv ?? throw new ArgumentOutOfRangeException();
        }
    }

    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length { get => _length; set => _length = value; }
        public double Width { get => _width; set => _width = value; }
        public double Area => Length * Width;

        public Rectangle(double? Length, double? Width)
        {
            this.Length = Length ?? throw new ArgumentNullException();
            this.Width = Width ?? throw new ArgumentNullException();
        }
    }
}
