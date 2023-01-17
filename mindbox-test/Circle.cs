using System;

namespace mindbox_test {
    public class Circle : IShape {
        private double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public double GetArea() {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}