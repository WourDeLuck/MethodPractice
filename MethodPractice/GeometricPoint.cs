using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    /// <summary>
    /// Simple geometric point class.
    /// Contains overriden operations.
    /// </summary>
    public class GeometricPoint
    {
        // Coordinate by axis X
        private double _axisX;
        // Coordinate by axis Y
        private double _axisY;

        // Encapsulated fields
        public double AxisX { get => _axisX; set => _axisX = value; }
        public double AxisY { get => _axisY; set => _axisY = value; }     

        // Counstructor of the class.
        public GeometricPoint(double x, double y)
        {
            AxisX = x;
            AxisY = y;
        }

        /// <summary>
        /// Overriden '==' operator for GeometricPoint type.
        /// </summary>
        /// <param name="point1">First point</param>
        /// <param name="point2">Second point</param>
        /// <returns>True, if the points coordinates are equal. False if not.</returns>
        public static bool operator ==(GeometricPoint point1, GeometricPoint point2)
        {
            if (point1.AxisX == point2.AxisX && point1.AxisY == point2.AxisY)
                return true;
            return false;
        }

        /// <summary>
        /// Overriden '!=' operator for GeometricPoint type.
        /// </summary>
        /// <param name="point1">First point.</param>
        /// <param name="point2">Second point.</param>
        /// <returns>True, if point coordinates are not equal.</returns>
        public static bool operator !=(GeometricPoint point1, GeometricPoint point2)
        {
            return !(point1 == point2);
        }

        /// <summary>
        /// Overriden Equals method for GeometricPoint type.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is GeometricPoint))
                return false;
            return this == (GeometricPoint)obj;
        }

        public override int GetHashCode()
        {
            return (int)System.Math.Sqrt(AxisX * AxisX + AxisY * AxisY);
        }

        /// <summary>
        /// Overriden '+' operator for GeometricPoint type.
        /// </summary>
        /// <param name="point1">First point.</param>
        /// <param name="point2">Second point.</param>
        /// <returns>Result of the point addition.</returns>
        public static GeometricPoint operator +(GeometricPoint point1, GeometricPoint point2)
        {
            return new GeometricPoint(point1.AxisX + point2.AxisX, point1.AxisY + point2.AxisY);
        }

        /// <summary>
        /// Overriden '-' operator for GeometricPoint type.
        /// </summary>
        /// <param name="point1">First point.</param>
        /// <param name="point2">Second point.</param>
        /// <returns>The result of substraction.</returns>
        public static GeometricPoint operator -(GeometricPoint point1, GeometricPoint point2)
        {
            return new GeometricPoint(point1.AxisX - point2.AxisX, point1.AxisY - point2.AxisY);
        }

        /// <summary>
        /// Defining the operator used for casting.
        /// Can be used for both safe and explicit casting.
        /// </summary>
        /// <param name="point"></param>
        public static implicit operator string(GeometricPoint point)
        {
            return point.AxisX + ", " + point.AxisY;
        } 


    }
}
