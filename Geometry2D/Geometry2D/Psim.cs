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

        public Vector(double? dx, double? dy)
        {
            DX = dx < -1 || dx > 1 ? throw new ArgumentOutOfRangeException() : dx ?? throw new ArgumentOutOfRangeException();
            DY = dy < -1 || dy > 1 ? throw new ArgumentOutOfRangeException() : dy ?? throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dx">X Vector</param>
        /// <param name="dy">Y Vector</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw exception if dx or yx is not in +-1 range or if it's null </exception>
        public void Set(double? dx, double? dy)
        {
            DX = dx < -1 || dx > 1 ? throw new ArgumentOutOfRangeException() : dx ?? throw new ArgumentOutOfRangeException();
            DY = dy < -1 || dy > 1 ? throw new ArgumentOutOfRangeException() : dy ?? throw new ArgumentOutOfRangeException();
        }
    }

    public class Rectangle
    {
        private int _length;
        private int _width;

        public int Length { get => _length; set => _length = value; }
        public int Width { get => _width; set => _width = value; }
        public int Area => Length * Width;

        public Rectangle(int? Length, int? Width)
        {
            this.Length = Length ?? throw new ArgumentNullException();
            this.Width = Width ?? throw new ArgumentNullException();
        }
    }
}
