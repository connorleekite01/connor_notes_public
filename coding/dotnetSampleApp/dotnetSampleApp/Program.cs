using sampleTriangleUtils;


String result = "NONE";

Console.WriteLine("hello world");

// init trianleUtil with default values
TriangleUtil trianleUtil = new TriangleUtil();
Console.Write("Triangle Type Test :-\n----------------------------\n\n");  


result = trianleUtil.CheckTriangleType(12, 12, 12);
Console.WriteLine(result);

result = trianleUtil.CheckTriangleType(12, 12, 15);
Console.WriteLine(result);

result = trianleUtil.CheckTriangleType(12, 20, 25);  
Console.WriteLine(result);