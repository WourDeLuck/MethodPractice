using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodPractice;

namespace Tests
{
    [TestClass]
    public class Test
    {
        GeometricPoint p1 = new GeometricPoint(3, 4);
        GeometricPoint p2 = new GeometricPoint(5, 6);

        [TestMethod]
        public void PointEqualTest()
        {
            Assert.IsFalse(p1 == p2);
        }

        [TestMethod]
        public void PointNotEqualTest()
        {
            Assert.IsTrue(p1 != p2);
        }

        [TestMethod]
        public void PointEqualsTest()
        {
            GeometricPoint point = new GeometricPoint(3.5, 4.5);
            GeometricPoint point1 = new GeometricPoint(3.5, 4.5);

            Assert.IsTrue(point.Equals(point1));
        }

        [TestMethod]
        public void AdditionTest()
        {
            GeometricPoint test = p1 + p2;
            GeometricPoint p3 = new GeometricPoint(8, 10);

            Assert.AreEqual(p3, test);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            GeometricPoint test = p1 - p2;
            GeometricPoint p3 = new GeometricPoint(-2, -2);

            Assert.AreEqual(p3, test);
        }

        [TestMethod]
        public void ExtensionMethodTest()
        {
            GeometricPoint point1 = new GeometricPoint(3, 9);
            GeometricPoint point2 = new GeometricPoint(1, 1);

            point1.MovePointTo(point2.AxisX, point2.AxisY);

            Assert.AreEqual(point2, point1);
        }

        [TestMethod]
        public void CastTest()
        {
            string test = p1;
            string test2 = (GeometricPoint)p2;

            Assert.IsTrue(test == "3, 4");
            Assert.IsTrue(test2 == "5, 6");
        }
    }
}
