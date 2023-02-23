namespace sampleCalculator;

public class Calculator
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
    
    public static bool CheckIfTwoDoublesAreEqual(double num1, double num2)
    {
        return num1 == num2;
    }
}