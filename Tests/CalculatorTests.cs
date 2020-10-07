using System;
using Xunit;
using Domain;

namespace Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(-10,5,-5)]
        [InlineData(1.5,-2,-0.5)]
        [InlineData(-54.5,-2.5,-57)]
        public void should_return_the(double firstNumber, double secondNumber, double expected)
        {
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(8,4,2)]
        [InlineData(0,6,0)]
        [InlineData(1,0,0)]
        [InlineData(1,0.5,2)]
        [InlineData(-10,5,-2)]
        [InlineData(8,-4,-2)]
        [InlineData(5.5,2,2.75)]
        [InlineData(55,9,6.111111111111111)]
        public void should_return_the_division_betwen_parameters(double firstNumber, double secondNumber, double expected)
        {
            var calculator = new Calculator();

            var result = calculator.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, result);
        }
    }
}
