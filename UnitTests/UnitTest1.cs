using FluentAssertions;
using Xunit;
using Calc = Calculator.Language.Calculator;

namespace UnitTests
{
    public class UnitTest1
    {
        private Calc calculator;

        public UnitTest1()
        {
            calculator = new Calc();
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("1+2+3", 6)]
        [InlineData("1+2*3", 7)]
        [InlineData("1*2+3", 5)]
        [InlineData("2^2^3", 256)]
        public void Check(string input, double output)
        {
            calculator.Calculate(input).Should().Be(output);
        }
    }
}
