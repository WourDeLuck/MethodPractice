using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    /// <summary>
    /// Static class with an extension method
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Allows to "move" the point to another location by changing the coordinates.
        /// </summary>
        /// <param name="point">Point to move</param>
        /// <param name="x">Coordinate by axis X</param>
        /// <param name="y">Coordinate by axis Y</param>
        public static void MovePointTo(this GeometricPoint point, double x, double y)
        {
            point.AxisX = x;
            point.AxisY = y;
        }
    }
}
