using AreaCalculator.Model;
using static TestsAreaCalculator.TestHelper;
using static System.Math;

namespace TestsAreaCalculator
{
    [TestFixture]
    public class TriangleTest
    {
        /// <summary>
        /// Нельзя создать треугольник со стороной, длина которой равна 0
        /// </summary>
        [Test]
        public void ShouldThrowIfSideIsZero()
        {
            // arrange
            var sideA = 0.0;
            var sideB = new Random().NewDouble();
            var sideC = new Random().NewDouble();

            // act and assert
            Assert.Throws<ArgumentException>(() => new Triangle(NewString(), sideA, sideB, sideC));
        }

        /// <summary>
        /// Нельзя создать треугольник с отрицательной стороной
        /// </summary>
        [Test]
        public void ShouldNotHaveNegativeSide()
        {
            // arrange
            var sideA = new Random().NewDouble(-100, -0.1);
            var sideB = new Random().NewDouble();
            var sideC = new Random().NewDouble();

            // act and assert
            Assert.Throws<ArgumentException>(() => new Triangle(NewString(), sideA, sideB, sideC));
        }

        /// <summary>
        /// Конструктор должен выбрасывать исключение если сумма длин двух сторон не меньше длины третьей стороны
        /// </summary>
        [Test]
        public void ShouldHaveSumLengthsTwoSidesMustBeLessThanLengthThirdSide()
        {
            // arrange
            var sideA = new Random().NewDouble();
            var sideB = new Random().NewDouble();
            var sideC = Sqrt(sideA * sideA + sideB * sideB) + 100;

            // act and assert
            Assert.Throws<ArgumentException>(() => new Triangle(NewString(), sideA, sideB, sideC));
        }

        /// <summary>
        /// Должен правильно считать площадь
        /// </summary>
        [Test]
        public void ShouldCorrectCalculateSquare()
        {
            // arrange
            var sideA = new Random().NewDouble();
            var sideB = new Random().NewDouble();
            var sideC = Sqrt(sideA * sideA + sideB * sideB);

            var p = (sideA + sideB + sideC) / 2;
            var expectedSquare = Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            // act
            var actualSquare = new Triangle(NewString(), sideA, sideB, sideC).GetSquare();

            // assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        /// <summary>
        /// Метод проверки что треугольник является прямоугольным должен это делать правильно
        /// </summary>
        [Test]
        public void ShouldCorrectCheckIsRight_True()
        {
            // arrange
            var sideA = new Random().NewDouble();
            var sideB = new Random().NewDouble();
            var sideC = Sqrt(sideA * sideA + sideB * sideB);

            // act
            var actualResult = new Triangle(NewString(), sideA, sideB, sideC).IsRight();

            // assert
            Assert.IsTrue(actualResult);
        }

        /// <summary>
        /// Метод проверки что треугольник является прямоугольным должен это делать правильно
        /// </summary>
        [Test]
        public void ShouldCorrectCheckIsRight_False()
        {
            // arrange
            var sideA = 10;
            var sideB = 20;
            var sideC = Sqrt(sideA * sideA + sideB * sideB) + 5;

            // act
            var actualResult = new Triangle(NewString(), sideA, sideB, sideC).IsRight();

            // assert
            Assert.IsFalse(actualResult);
        }

        /// <summary>
        /// Нельзя создать треугольник со стороной, длина которой равна 0
        /// </summary>
        /* почему-то not run [TestCaseSource(nameof(TriangleZeroSides))]
        public void ShouldThrowIfSideIsZero(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(NewString(), sideA, sideB, sideC));
        }

        public static object[] TriangleZeroSides =
        {
            new double[] {0.0, new Random().NewDouble(), new Random().NewDouble()},
            new double[] { new Random().NewDouble(), 0.0, new Random().NewDouble()},
            new double[] { new Random().NewDouble(), new Random().NewDouble(), 0.0 }
        };*/
    }
}
