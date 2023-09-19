using Wati.API.Controllers;
using Xunit;

namespace Wait.API.Tests
{
    public class CalculatorTests
    {
        CalculatorController _calculatorController;

        public CalculatorTests()
        {
            _calculatorController = new CalculatorController();
        }

        [Fact]
        public void Add_Number_Positive_PositiveNumber_Tests()
        {
            // Arrange


            // Act
            int result = _calculatorController.Add(2, 3);

            // Assert 
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_Number_Positive_NegativeNumber_Tests()
        {
            // Arrange


            // Act
            int result = _calculatorController.Add(-2, -3);

            // Assert 
            Assert.Equal(-5, result);
        }
    }
}