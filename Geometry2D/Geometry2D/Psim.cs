using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _x = Double.IsNaN(value) ? 1 : value; // If the value passed is not a number set X to 1
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                _y = Double.IsNaN(value) ? 1 : value; // If the value passed is not a number set Y to 1
            }
        }

        public Point()
        {

        }
        
        /// <summary>
        /// Instantiate Point class with predefined X and Y coordinates
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        public Point(double? x, double? y)
        {
            X = x ?? throw new ArgumentException();
            Y = y ?? throw new ArgumentException();
        }

        /// <summary>
        /// Set X and Y coordinates
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
                _dx = Double.IsNaN(value) ? 1 : value; // If the value passed is not a number set DX to 1
            }
        }

        public double DY
        {
            get => _dy;
            set
            {
                _dy = Double.IsNaN(value) ? 1 : value; // If the value passed is not a number set DY to 1
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
            this.Length = Length ?? throw new ArgumentException();
            this.Width = Width ?? throw new ArgumentException();
        }
    }
}
