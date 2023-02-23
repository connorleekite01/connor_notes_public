namespace sampleCalculatorTest;

using NUnit.Framework;
using sampleCalculator;
public class CalculatorLibraryTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    // Test the Add method of the calculator class
    [Test]
    public void TestAdd()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        int expected = 30;
        
        // Act
        int actual = Calculator.Add(num1, num2);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    // Test the Subtract method of the calculator class
    [Test]
    public void TestSubtract()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        int expected = -10;
        
        // Act
        int actual = Calculator.Subtract(num1, num2);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    // Test the Multiply method of the calculator class
    [Test]
    public void TestMultiply()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        int expected = 200;
        
        // Act
        int actual = Calculator.Multiply(num1, num2);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    // Test the divide method of the calculator class
    [Test]
    public void TestDivide()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        int expected = 0;
        
        // Act
        int actual = Calculator.Divide(num1, num2);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }

    // test the CheckIfTwoDoublesAreEqual method of the calculator class
    [Test]
    public void TestCheckIfTwoDoublesAreEqual()
    {
        // Arrange
        double num1 = 10.0;
        double num2 = 10.0;
        bool expected = true;
        
        // Act
        bool actual = Calculator.CheckIfTwoDoublesAreEqual(num1, num2);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }

}