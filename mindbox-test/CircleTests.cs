using NUnit.Framework;

namespace mindbox_test {
    [TestFixture]
    public class CircleTests {
        [Test]
        public void TestGetArea() {
            var circle = new Circle(5);
            Assert.AreEqual(78.5398, circle.GetArea(), 0.0001);
        }

        [Test]
        public void TestGetAreaWithNegativeRadius() {
            var circle = new Circle(-5);
            Assert.AreEqual(78.5398, circle.GetArea(), 0.0001);
        }

        [Test]
        public void TestGetAreaWithZeroRadius() {
            var circle = new Circle(0);
            Assert.AreEqual(0, circle.GetArea(), 0.0001);
        }
    }
}