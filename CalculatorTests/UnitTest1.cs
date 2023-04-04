using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorLibraryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_WhenGivenTwoIntegers4and6_shouldReturnAdditionAs10()
        {
            // Arrange
            Calculator Calculator = new ();
            int num1 = 4;
            int num2 = 6;
            // Act
            int actualAddition = Calculator.Add(num1, num2);

            // Assert
            int expectedAddition = num1 + num2;
            Assert.AreEqual(expectedAddition, actualAddition);
        }
    }
}