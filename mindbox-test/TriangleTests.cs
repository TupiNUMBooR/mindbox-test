using System;
using NUnit.Framework;

namespace mindbox_test {
    [TestFixture]
    public class TriangleTests {
        [Test]
        public void TestIsRightTriangle() {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void TestNotRightTriangle() {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [Test]
        public void TestInvalidTriangle() {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
        }

        [Test]
        public void TestGetArea() {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.01);
        }
    }
}