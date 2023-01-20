using Xunit;
using KataCalculator;
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
        
        public void Add_Emptystrung_Return0()
        {
            int actual = calculator.Add(" ");
            Assert.Equal(0, actual);    

        }

        [Theory]
        [InlineData("0")]
        public void Add_OneNumber_ReturnSameNumber(string x)
        {
            int actual = calculator.Add(x);
            Assert.Equal(0, actual);

        }

        [Theory]
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
        [InlineData("0,1,4", 5)]
        [InlineData("2,1", 3)]
        [InlineData("2,2,1,10", 15)]
        [InlineData("1,1,8,2,1", 13)]
        public void Add_UnKnownAmountOfNumbers_ReturnSum(string x, int expected)
        {
            int actual = calculator.Add(x);
            Assert.Equal(expected, actual);

        }


    }
}