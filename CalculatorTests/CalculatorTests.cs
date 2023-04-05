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
        public void Add_WhenGivenTwoIntegers_shouldReturnAddition()
        {
            // Arrange
            Calculator calculator = new ();
            int num1 = 4;
            int num2 = 6;
            // Act
            int actualAddition = calculator.Add(num1, num2);

            // Assert
            int expectedAddition = num1 + num2;
            Assert.AreEqual(expectedAddition, actualAddition);
        }

        [Test]
        public void Sub_WhenGivenTwoIntegers_shouldReturnSubstracting()
        {
            Calculator calculator = new ();
            int num1 = 6;
            int num2 = 4;

            int actualSubtraction = calculator.Sub(num1, num2);

            int expectedSubstraction = num1 - num2;
            Assert.AreEqual(expectedSubstraction, actualSubtraction);
        }
    }
}