namespace AreaCalculator.Model
{
    public abstract class FigureBase
    {
        public string Name { get; private set; }

        public FigureBase(string name) => Name = name;

        abstract public double GetSquare();
    }
}
