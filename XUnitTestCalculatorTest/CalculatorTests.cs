using System;
using Assignment_1;
using Xunit;

namespace XUnitTestCalculatorTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Task_Add_ResultTrue()
        {
            //Arrange
            var num1 = 40;
            var num2 = -3;
            var expectedValue = 37;

            //Act
            var sum = Assignment_1.Addition(num1, num2);

            //Assert
            Assert.Equal(expectedValue, sum, 1);


        }
    }
}
