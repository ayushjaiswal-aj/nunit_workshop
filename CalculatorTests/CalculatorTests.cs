using CalculatorLibrary;
using NUnit.Framework;
using System;

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
            Calculator calculator = new();
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
            Calculator calculator = new();
            int num1 = 6;
            int num2 = 4;

            int actualSubtraction = calculator.Sub(num1, num2);

            int expectedSubstraction = num1 - num2;
            Assert.AreEqual(expectedSubstraction, actualSubtraction);
        }

        [Test]
        public void Multiply_WhenGivenTwoIntegers_shouldReturnMultiplication()
        {
            Calculator calculator = new();
            int num1 = 6;
            int num2 = 4;

            int actualMultiplication = calculator.Multiply(num1, num2);

            int expectedMultiplication = num1 * num2;
            Assert.AreEqual(expectedMultiplication, actualMultiplication);
        }

        [Test]
        public void Divide_WhenGivenTwoIntegers_shouldReturnDivision()
        {
            Calculator calculator1 = new();
            int num1 = 8;
            int num2 = 4;

            int actualDivision = calculator1.Divide(num1, num2);

            int expectedDivision = num1 / num2;

            Assert.AreEqual(expectedDivision, actualDivision);
        }

        [Test]
        public void Divide_WhenGiven0AsDenominator_shouldThrowDivideByZeroException()
        {
            Calculator calculator1 = new();
            int num1 = 8;
            int num2 = 0;

            Assert.Throws<DivideByZeroException>(() => calculator1.Divide(num1, num2));
        }
    }
}