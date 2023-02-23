namespace sampleTriangleUtils;

using sampleCalculator;

public class TriangleUtil
{
    private double eqSide1, eqSide2, eqSide3;

    public double EqSide1
    {
        get => eqSide1;
        set => eqSide1 = value;
    }

    public double EqSide2
    {
        get => eqSide2;
        set => eqSide2 = value;
    }

    public double EqSide3
    {
        get => eqSide3;
        set => eqSide3 = value;
    }

    public TriangleUtil(double eqSide1, double eqSide2, double eqSide3)
    {
        this.eqSide1 = eqSide1;
        this.eqSide2 = eqSide2;
        this.eqSide3 = eqSide3;
    }

    public TriangleUtil()
    {
        // init with default values
        this.eqSide1 = 0;
        this.eqSide2 = 0;
        this.eqSide3 = 0;
    }

    public String CheckTriangleType(double side1, double side2, double side3)
    {
        Console.WriteLine("TriangleUtil Function has values: {0}, {1}, {2}", side1, side2, side3);
        string TriangleType = "NONE";
        if ((Calculator.CheckIfTwoDoublesAreEqual(side1, side2) && Calculator.CheckIfTwoDoublesAreEqual(side1, side3)))
        {
            TriangleType = "Equilateral";
        }
        else if (Calculator.CheckIfTwoDoublesAreEqual(side1, side2) ||
                 Calculator.CheckIfTwoDoublesAreEqual(side1, side3) ||
                 Calculator.CheckIfTwoDoublesAreEqual(side2, side3))
        {
            TriangleType = "Isosceles";
            eqSide1 = side1;
            eqSide2 = side2;
            eqSide3 = side3;
        }
        else
        {
            TriangleType = "Scalene";
        }

        return TriangleType;
    }
}