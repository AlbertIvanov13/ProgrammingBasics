string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double comission = 0;

switch (city)
{
    case "Sofia":
        if (sales < 0)
        {
            Console.WriteLine("error");
        }
        else if (sales >= 0 && sales <= 500)
        {
            comission = sales * 5 / 100;
        }
        else if (sales > 500 && sales <= 1000)
        {
            comission = sales * 7 / 100;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            comission = sales * 8 / 100;
        }
        else
        {
            comission = sales * 12 / 100;
        }
        break;
    case "Varna":
        if (sales < 0)
        {
            Console.WriteLine("error");
        }
        else if (sales >= 0 && sales <= 500)
        {
           comission = sales * 4.5 / 100;
        }
        else if (sales > 500 && sales <= 1000)
        {
            comission = sales * 7.5 / 100;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            comission = sales * 10 / 100;
        }
        else
        {
            comission = sales * 13 / 100;
        }
        break;
    case "Plovdiv":
        if (sales < 0)
        {
            Console.WriteLine("error");
        }
        else if (sales >= 0 && sales <= 500)
        {
            comission = sales * 5.5 / 100;
        }
        else if (sales > 500 && sales <= 1000)
        {
            comission = sales * 8 / 100;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            comission = sales * 12 / 100;
        }
        else
        {
            comission = sales * 14.5 / 100;
        }
        break;
    default:
        Console.WriteLine("error");
        break;
        
}

if (comission > 0) 
{
    Console.WriteLine($"{comission:f2}");
}