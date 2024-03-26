double r = double.Parse(Console.ReadLine());

double calculatedArea = Math.PI * r * r;

double calculatedParameter = 2 * (Math.PI * r);

Console.WriteLine("{0:F2}", calculatedArea);
Console.WriteLine("{0:F2}", calculatedParameter);


