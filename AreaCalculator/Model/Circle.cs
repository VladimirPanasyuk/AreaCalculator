namespace AreaCalculator.Model
{
    /// <summary>
    /// круг
    /// </summary>
    public class Circle : FigureBase
    {
        private readonly double _raduis;

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="name">название круга</param>
        /// <param name="radius">радиус круга</param>
        /// <exception cref="ArgumentException">если передан отрицательный радиус или равный нулю.</exception>
        public Circle(string name, double radius) : base(name)
        {
            if (radius <= 0.0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            _raduis = radius;
        }

        public override double GetSquare() => double.Pi * _raduis * _raduis;
    }
}
