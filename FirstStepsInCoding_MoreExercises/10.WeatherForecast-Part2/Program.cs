﻿double degrees = double.Parse(Console.ReadLine());

if (degrees >= 26.00 && degrees <= 36.00)
{
    Console.WriteLine("Hot");
}
else if (degrees >= 20.1 && degrees <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (degrees >= 15.00 && degrees <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (degrees >= 12.00 && degrees <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (degrees >= 5.00 && degrees <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}

//Console.ReadKey();
