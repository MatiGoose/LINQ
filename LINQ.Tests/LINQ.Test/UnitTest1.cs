using System.Collections.Generic;
using Xunit;

namespace LINQ.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void SquareEvenCollectionElements_SelectEvenElementsAndSquare_Result16And4()
        {
            Calculator calculator = new Calculator();
            List<int> myARR = new List<int>
            {
                1,
                5,
                4,
                2
            };

            var result = calculator.Square_even_elements(myARR);

            Assert.Contains(16, result);
            Assert.Contains(4, result);
            Assert.DoesNotContain(25, result);
            Assert.DoesNotContain(1, result);
        }
        [Fact]
        public void FindMax_FindMaxElemntOfCollection_Result5()
        {
            Calculator calculator = new Calculator();
            List<int> myARR = new List<int>
            {
                1,
                5,
                4,
                2
            };
            int max = calculator.Find_max(myARR);
            Assert.Equal(5, max);
        }
        [Fact]
        public void Multiply_Multiply5and25_Result125()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(5, 25);
            Assert.Equal(125, result);
        }
        [Theory]
        [InlineData(8, 3, 11)]
        [InlineData(-1, -10, -11)]
        public void Sum_SumAandB_ExpectedResult(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(8, 3, 5)]
        [InlineData(-1, -10, 9)]
        public void Substract_SubstractAandB_ExpectedResult(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }
    }
}
