namespace testSampleTriangleUtils;
using NUnit.Framework;
using sampleTriangleUtils;

public class Tests
{
    
    private TriangleUtil trianleUtil;
    [SetUp]
    public void Setup()
    {
        // setup
        trianleUtil = new TriangleUtil();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    // unit test for TriangleUtil, checkTriangleType method, check if it returns "Equilateral" for 3 equal sides
    [Test]
    public void TestTriangleUtilCheckTriangleTypeEquilateral()
    {
        // arrange
        string expected = "Equilateral";
        // act
        string result = trianleUtil.CheckTriangleType(12, 12, 12);
        // assert
        Assert.AreEqual(expected, result);
    }
    
    // unit test for TriangleUtil, checkTriangleType method, check if it returns "Isosceles" for 2 equal sides
    [Test]
    public void TestTriangleUtilCheckTriangleTypeIsosceles()
    {
        // arrange
        string expected = "Isosceles";
        // act
        string result = trianleUtil.CheckTriangleType(12, 12, 15);
        // assert
        Assert.AreEqual(expected, result);
    }
    
    // unit test for TriangleUtil, checkTriangleType method, check if it returns "Equilateral" for 3 equal sides
    [Test]
    public void TestTriangleUtilCheckTriangleTypeScalene()
    {
        // arrange
        string expected = "Scalene";
        // act
        string result = trianleUtil.CheckTriangleType(12, 20, 25);
        // assert
        Assert.AreEqual(expected, result);
    }

}