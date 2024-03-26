int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

switch (dayOfWeek)
{
    case "Monday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Tuesday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Wednesday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Thursday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Friday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Saturday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    default:
        Console.WriteLine("closed");
        break;
}