using ConsoleApp5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        //Для TestIsPointInside
        [TestCase(54, 37, true)]
        [TestCase(54, 12, true)]
        [TestCase(93, 12, true)]
        [TestCase(20, 12, true)]
        [TestCase(20, 37, true)]
        public void TestIsPointInside(int x, int y, bool expectedResult)
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(108, 50);
            Hexagon hexagon = new Hexagon(point1, point2);
            Point testPoint = new Point(x, y);
            var result = hexagon.IsPointInside(testPoint);
            Assert.AreEqual(expectedResult, result);
        }

        //Для TestIsPointNotInside
        [TestCase(10, 37, false)]
        [TestCase(10, 12, false)]
        [TestCase(0, 0, false)]
        [TestCase(108, 50, false)]
        [TestCase(98, 12, false)]
        [TestCase(98, 37, false)]
        public void TestIsPointNotInside(int x, int y, bool expectedResult)
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(108, 50);
            Hexagon hexagon = new Hexagon(point1, point2);
            Point testPoint = new Point(x, y);
            var result = hexagon.IsPointInside(testPoint);
            Assert.AreEqual(expectedResult, result);
        }

        //Для TestIsPointInBorder
        [TestCase(0, 25, true)]
        [TestCase(108, 25, true)]
        [TestCase(54, 0, true)]
        [TestCase(54, 50, true)]
        [TestCase(25, 0, true)]
        [TestCase(83, 0, true)]
        [TestCase(25, 50, true)]
        [TestCase(83, 50, true)]
        public void TestIsPointInBorder(int x, int y, bool expectedResult)
        {
             Point point1 = new Point(0, 0);
             Point point2 = new Point(108, 50);
             Hexagon hexagon = new Hexagon(point1, point2);
             Point testPoint = new Point(x, y);
             var result = hexagon.IsPointInside(testPoint);
             Assert.AreEqual(expectedResult, result);
        }

        [TestCase]
        public void TestGetHexagonPoints()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(108, 50);
            Hexagon hexagon = new Hexagon(point1, point2);

            Point testPointP1 = new Point(83, 0);
            Point testPointP2 = new Point(25, 0);
            Point testPointP3 = new Point(0, 25);
            Point testPointP4 = new Point(25, 50);
            Point testPointP5 = new Point(83, 50);
            Point testPointP6 = new Point(108, 25);
            Hexagon hex = new Hexagon(testPointP1, testPointP2, testPointP3, testPointP4, testPointP5, testPointP6);
            Assert.AreEqual(hex, hexagon);

        }
    }
}
