double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

//Walls
double sideWall = x * y;
double window = 1.5 * 1.5;
double twoSides = 2 * sideWall - 2 * window;
double backWall = x * x;
double entrance = 1.2 * 2;

double totalBackAndFront = 2 * backWall - entrance;

double totalSpace = twoSides + totalBackAndFront;

double greenPaint = totalSpace / 3.4;

//Roof
double twoSidesRoof = 2 * (x * y);
double twoTriangles = 2 * (x * h / 2);

double totalRoofSpace = twoSidesRoof + twoTriangles;

double redPaint = totalRoofSpace / 4.3;

Console.WriteLine("{0:F2}", greenPaint);
Console.WriteLine("{0:F2}", redPaint);