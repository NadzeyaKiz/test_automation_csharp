using CSharpCalculator;

namespace TestProject1
{
    public class CalculatorNUnitTests
    {
        CSharpCalculator.Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(6, 0, 6)]
        [TestCase(-5, 5, 0)]
        [TestCase(5, -5, 0)]
        [TestCase(-5, -5, -10)]
        public void AddReturnsCorrectSumTest(double a, double b, double expectedSum)
        {
            // Precondition: numbers a and b to add, expected sum expectedSum
            // Verify: Assert that the Add method returns the correct amount for various inputs
            double actualResult = calculator.Add(a, b);
            Assert.AreEqual(expectedSum, actualResult, $"Incorrect sum result of {a} and {b}");
        }

        [Test]
        [TestCase(5, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, -5)]
        [TestCase(6, 0, 6)]
        [TestCase(0, -5, 5)]
        [TestCase(-10, 5, -15)]
        [TestCase(10, -5, 15)]
        [TestCase(-10, -5, -5)]
        public void SubtractReturnCorrectDifferenceTest(double a, double b, double expectedSubstract)
        {
            // Precondition: numbers a and b to subtract, expectedDifference
            // Verify: Assert that the Subtract method returns the correct difference for various inputs
            double actualResult = calculator.Sub(a, b);
            Assert.AreEqual((double)expectedSubstract, actualResult, $"Incorrect difference of numbers {a} and {b}" );
        }

        [Test]
        [TestCase(3, 4, 12)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 0, 0)]
        [TestCase(0, 5, 0)]
        [TestCase(-2, 3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(5, -2, -10)]
        public void MultiplyReturnCorrectProductTest(double a, double b, double expectedProduct)
        {
            // Precondition: numbers a and b to be multiplied, expected product expectedProduct
            // Verify: Assert that the Multiply method returns the correct product for different inputs
            double actualResult = calculator.Multiply(a, b);
            Assert.AreEqual((double)expectedProduct, actualResult, $"Incorrect product of numbers {a} and {b}");
        }

        [Test]
        [TestCase(20, 4, 5)]
        [TestCase(0, -7, 0)]
        [TestCase(0, 5, 0)]
        [TestCase(-10, -2, 5)]
        [TestCase(-16, 4, -4)]
        [TestCase(16, -4, -4)]
        public void DivideReturnCorrectQuotient(double a, double b, double expectedQuotient)
        {
            // Precondition: numbers a and b to divide, expected quotient expectedQuotient
            // Verify: Assert that the Divide method returns the correct quotient for various inputs
            double actualResult = calculator.Divide(a, b);
            Assert.AreEqual((double)expectedQuotient, actualResult, $"Incorrect quotient of numbers {a} and {b}");
        }

        [Test]
        [TestCase(7, 0)]
        [TestCase(-7, 0)]
        public void DividingByZeroTest(double a, double b)
        {
            // Precondition: division by zero
            // Test: assert that the Divide method throws an exception of type DivideByZeroException            
            double result = calculator.Divide(a, b);
            Assert.That(result, Is.EqualTo(double.PositiveInfinity).Or.EqualTo(double.NegativeInfinity));
        }
        
        [Test]        
        [TestCase("abc", 5, "Invalid input: non-numeric string")]
        [TestCase("", 10, "Invalid input: empty string")]
        public void ThrowExceptionInvalidInputAdditing(string input, int b, string testcaseDescription)
        {
            // Precondition: incorrect input of a string instead of a number
            // Verify: Assert that the Add method throws an exception of type FormatException
            Assert.Throws(Is.InstanceOf<Exception>(), () => calculator.Add(input, b));
        }

        [Test]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(25, 5)]
        [TestCase(0, 0)]
        public void SqrtResultTest(double number, double expectedResult)
        {
            // Precondition: valid input data
            // Verify: Assert that the Sqrt method returns the correct result for valid input
            double result = calculator.Sqrt(number);
                        
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        [TestCase(10, -2, 0.01)]
        public void PowValidInputResultTest(double a, int b, double expectedResult)
        {
            // Assumption: integer and double values should be accepted in both parameters
            // Precondition: valid input data
            // Validate: assert that the Pow method returns the correct result for valid input
            // fails due to too many casts (double)((object)((double)2)) or (int)((object)((double)2.0))
            double result = calculator.Pow(a, b);

            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [Test]
        [TestCase(2, 3.0, 8)]
        [TestCase(3, 2.0, 9)]
        [TestCase(4, 0.0, 1)]
        [TestCase(-2, 2.0, 4)]
        [TestCase(10, -2.0, 0.01)]
        public void PowInputResultWithPowerDoubleTest(int a, double b, double expectedResult)
        {            
            // Precondition: valid input data
            // Validate: assert that the Pow method returns the correct result for valid input
            double result = calculator.Pow(a, b);

            Assert.AreEqual(expectedResult, result, 0.00);
        }

        [Test]
        [TestCase("abc", 2)]
        [TestCase(null, 3)]
        [TestCase(double.NaN, 2)]
        public void PowInvalidInputResultTest(object a, double b)
        {
            // Precondition: invalid input data
            // Test: assert that the Pow method throws an exception of type NotFiniteNumberException
            Assert.Throws<NotFiniteNumberException>(() => calculator.Pow(a, b));
        }
    }
}