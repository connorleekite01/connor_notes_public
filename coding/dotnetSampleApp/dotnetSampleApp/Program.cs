using sampleTriangleUtils;
using sampleCalculator;

String result = "NONE";
Console.WriteLine("hello world");

// init trianleUtil with default values
TriangleUtil trianleUtil = new TriangleUtil();
Console.Write("Triangle Type Test :-\n----------------------------\n\n");  

// sample tun for triangle classes
result = trianleUtil.CheckTriangleType(12, 12, 12);
Console.WriteLine(result);

result = trianleUtil.CheckTriangleType(12, 12, 15);
Console.WriteLine(result);

result = trianleUtil.CheckTriangleType(12, 20, 25);  
Console.WriteLine(result);

// sample tun for calculator classes
Console.WriteLine("Calculator Test :-\n----------------------------\n\n");
Console.WriteLine(Calculator.Add(12, 12));
Console.WriteLine(Calculator.Subtract(12, 12));
Console.WriteLine(Calculator.Multiply(12, 12));
Console.WriteLine(Calculator.Divide(12, 12));