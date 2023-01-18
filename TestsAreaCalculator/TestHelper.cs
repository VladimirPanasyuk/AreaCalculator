namespace TestsAreaCalculator
{
    internal static class TestHelper
    {
        public static string NewString() => Guid.NewGuid().ToString();

        public static double NewDouble(this Random RandGenerator, double MinValue = 0.1, double MaxValue = 100.0) => RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue;
    }
}
