namespace TestProject2
{
    public class CalcXUnitTests
    {
        CSharpCalculator.Calculator calculator = new CSharpCalculator.Calculator();
        
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-2, 3, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, -10)]
        public void AddReturnsCorrectSumTest(double a, double b, double expectedSum)
        {
            //Precondition: Two double numbers a and b to add, and the expected sum expectedSum.
            //Test: check that Add method returns the correct sum for different input values.
            double actualResult = calculator.Add(a, b);
            Assert.Equal(expectedSum, actualResult);
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(-5, 2, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -2, -8)]
        public void SubtractReturnCorrectDifferenceTest(double a, double b, double expectedDifference)
        {
            // Precondition: Two double numbers a and b to subtract, and the expected difference expectedDifference.
            //Test: Check that the Sub method returns the correct difference for different input values.
            double actualResult = calculator.Sub(a, b);
            Assert.Equal(expectedDifference, actualResult);
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(-3, 4, -12)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -3, 6)]
        public void MultiplyReturnCorrectProductTest(double a, double b, double expectedProduct)
        {
            //Precondition: Two double numbers a and b to multiply, and the expected product expectedProduct.
            //Test: Check that Multiply method returns the correct product for different input values.
            double actualResult = calculator.Multiply(a, b);
            Assert.Equal(expectedProduct, actualResult);
        }

        [Theory]
        [InlineData(20, 4, 5)]
        [InlineData(0, -7, 0)]
        [InlineData(-16, 4, -4)]
        public void DivideReturnCorrectQuotient(double a, double b, double expectedQuotient)
        {
            //Precondition: Two double numbers a and b to divide, and the expected quotient expectedQuotient.
            //Test: Check that the Divide method returns the correct quotient for different input values.
            double actualResult = calculator.Divide(a, b);
            Assert.Equal(expectedQuotient, actualResult);
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(25, 5)]
        public void SqrtResultTest(double number, double expectedResult)
        {
            //Precondition: A double number number for which to calculate the square root.
            //Test: Check that the Sqrt method returns the correct square root for different input values.
            expectedResult = Math.Sqrt(number);
            double result = calculator.Sqrt(number);
            Assert.Equal(expectedResult, result);
        }
               
        [Theory]
        [InlineData(5, true)]
        [InlineData(-5, false)]
        [InlineData(0, false)]
        public void isPositiveReturnsCorrectValueTest(double number, bool expectedValue)
        {
            //Precondition: A double number number to check if it is positive, and the expected boolean expectedValue.
            //Test: Chek that the isPositive method correctly determines whether the given number is positive.
            bool actualResult = calculator.isPositive(number);
            Assert.Equal(expectedValue, actualResult);
        }

        [Theory]
        [InlineData(5, false)]
        [InlineData(-5, true)]
        [InlineData(0, true)]
        public void isNegativeReturnsCorrectValueTest(double number, bool expectedValue)
        {
            //Precondition: A double number number to check if it is negative, and the expected boolean expectedValue.
            //Test Description: Check that the isNegative method correctly determines whether the given number is negative.
            bool actualResult = calculator.isNegative(number);
            Assert.Equal(expectedValue, actualResult);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(Math.PI / 2, 1)]
        [InlineData(Math.PI, 0)]
        [InlineData(Math.PI * 1.5, -1)]
        [InlineData(Math.PI * 2, 0)]
        public void SinReturnsCorrectValueTest(double angle, double expectedResult)
        {
            //Precondition: An angle in radians angle and the expected sine value expectedResult.
            //Test: Check that the Sin method returns the correct sine value for different input angles.
            double actualResult = calculator.Sin(angle);
            Assert.Equal(expectedResult, actualResult, 10); // Using a delta of 10 to handle floating-point precision
        }

        [Fact]
        public void SinThrowsExceptionForInvalidInputTest()
        {
            //Precondition: An invalid input represented as an object invalidInput.
            //Test: Check that the Sin method class throws a NotFiniteNumberException with the expected error message when invalid input is provided.
            object invalidInput = "abc";

            var ex = Assert.Throws<NotFiniteNumberException>(() => calculator.Sin(invalidInput));
            Assert.Equal("Wrong input", ex.Message);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(Math.PI / 3, 0.5)]
        [InlineData(Math.PI / 2, 0)]
        [InlineData(Math.PI, -1)]
        [InlineData(2 * Math.PI, 1)]
        public void CosCorrectValueTest(double angle, double expectedCos)
        {
            // Precondition: valid input data
            // Test: Assert that the Cos method returns the correct cosine value for valid input
            double actualResult = calculator.Cos(angle);
            Assert.Equal(expectedCos, actualResult, 10); // Using a delta of 10 to handle floating-point precision
        }

        [Theory]
        [InlineData("abc")]        
        public void CosExceptionInvalidInputTest(object invalidInput)
        {
            // Precondition: invalid input data
            // Test: Assert that the Cos method throws an exception of type NotFiniteNumberException
            var ex = Assert.Throws<NotFiniteNumberException>(() => calculator.Cos(invalidInput));
            Assert.Equal("Wrong input", ex.Message);
        }
    }
}