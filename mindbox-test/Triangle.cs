using System;

namespace mindbox_test {
    public class Triangle {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC) {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Not a valid triangle");
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double GetArea() {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool IsRightTriangle() {
            return IsRightTriangleSide(sideA, sideB, sideC) ||
                   IsRightTriangleSide(sideB, sideA, sideC) ||
                   IsRightTriangleSide(sideC, sideA, sideB);
        }

        private static bool IsRightTriangleSide(double h, double l1, double l2) {
            return Math.Abs(l1 * l1 + l2 * l2 - h * h) < 0.0001;
        }
    }
}