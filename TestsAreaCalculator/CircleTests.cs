using AreaCalculator.Model;
using static TestsAreaCalculator.TestHelper;

namespace TestsAreaCalculator
{
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// ����������� ������ ��������� ���������� ���� ������� ������������� ������ ��� 0
        /// </summary>
        [TestCase(0.0)]
        [TestCase(-5.5)]
        public void ShouldThrowExceptionIfRaduisIsZeroOrNegative(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(NewString(), 0.0));
        }

        /// <summary>
        /// ����� ����������� ���������� ������� ����� �� �������
        /// </summary>
        [Test]
        public void ShouldCorrectCalculateSquare()
        {
            // arrange
            var radius = new Random().NewDouble();
            var circle = new Circle(NewString(), radius);

            // act and assert
            Assert.That(circle.GetSquare(), Is.EqualTo(Math.PI * radius * radius));
        }
    }
}