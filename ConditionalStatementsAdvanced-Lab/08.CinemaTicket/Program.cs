﻿string dayOfWeek = Console.ReadLine();


switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
        Console.WriteLine(12);
        break;
    case "Wednesday":
    case "Thursday":
        Console.WriteLine(14);
        break;
    case "Friday":
        Console.WriteLine(12);
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine(16);
        break;
}