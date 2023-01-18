using static System.Math;

namespace AreaCalculator.Model
{
    /// <summary>
    /// класс треугольник
    /// </summary>
    public class Triangle : FigureBase
    {
        private readonly double[] _sides;

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="name">название треугольника</param>
        /// <param name="sideA">длина стороны А</param>
        /// <param name="sideB">длина стороны B</param>
        /// <param name="sideC">длина стороны С</param>
        /// <exception cref="ArgumentException">если переданы некоректные параметры</exception>
        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Длина стороны не может быть отрицательной.");
            else if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
                throw new ArgumentException("Длины сторон не образуют треугольник.");

            _sides = new double[] { sideA, sideB, sideC };
        }

        /// <summary>
        /// Посчитать площадь треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            var p = (_sides[0] + _sides[1] + _sides[2]) / 2;
            return Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
        }

        /// <summary>
        /// Проверка на то что треугольник прямоугольный
        /// </summary>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public bool IsRight(double epsilon = 1E-6)
        {
            Array.Sort(_sides);

            return Abs(Pow(_sides[0], 2) + Pow(_sides[1], 2) - Pow(_sides[2], 2)) <= epsilon ? true : false;
        }
    }
}
