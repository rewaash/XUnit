using Xunit;
using KataCalculator;
using System.ComponentModel;

namespace CalculatorTest
{
    public class TestKata
    {
        Calculator calculator;

        public TestKata()
        {
            calculator = new Calculator();
        }

        [Fact]
        [Category("The simplest thing")]
        
        public void Add_Emptystrung_Return0()
        {
            int actual = calculator.Add(" ");
            Assert.Equal(0, actual);    

        }

        [Theory]
        [InlineData("0")]
        [Category("The simplest thing")]
        public void Add_OneNumber_ReturnSameNumber(string x)
        {
            int actual = calculator.Add(x);
            Assert.Equal(0, actual);

        }

        [Theory]
        [Category("The simplest thing")]
        [InlineData("0,1",1)]
        [InlineData("2,1",3)]
        [InlineData("2,2", 4)]
        [InlineData("1,1", 2)]
        public void Add_TwoNumbers_ReturnSum(string x ,int expected)
        {
            int actual = calculator.Add(x);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [Category("UnKnownAmountOfNumber")]
        [InlineData("0,1,4", 5)]
        [InlineData("2,1", 3)]
        [InlineData("2,2,1,10", 15)]
        [InlineData("1,1,8,2,1", 13)]
        public void Add_UnKnownAmountOfNumbers_ReturnSum(string x, int expected)
        {
            int actual = calculator.Add(x);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [Category("UnKnownAmountOfNumber")]
        [InlineData("2,3\n1,2", 8)]
        [InlineData("2,,3\n4", 9)]
        [InlineData("3,2\n\n5", 10)]

        public void Add_WithLinesAndCommas_ReturnSum(string katastring, int expected)
        {

            ApplyAndTest(katastring, expected);
        }
        private void ApplyAndTest(string katastring, int expected)
        {
            int Actual = calculator.Add(katastring);
            Assert.Equal(expected, Actual);
        }

    }
}