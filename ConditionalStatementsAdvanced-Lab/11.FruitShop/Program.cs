string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double priceOfProduct = 0;

switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                priceOfProduct = 2.50;
                break;
            case "apple":
                priceOfProduct = 1.20;
                break;
            case "orange":
                priceOfProduct = 0.85;
                break;
            case "grapefruit":
                priceOfProduct = 1.45;
                break;
            case "kiwi":
                priceOfProduct = 2.70;
                break;
            case "pineapple":
                priceOfProduct = 5.50;
                break;
            case "grapes":
                priceOfProduct = 3.85;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
         break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                priceOfProduct = 2.70;
                break;
            case "apple":
                priceOfProduct = 1.25;
                break;
            case "orange":
                priceOfProduct = 0.90;
                break;
            case "grapefruit":
                priceOfProduct = 1.60;
                break;
            case "kiwi":
                priceOfProduct = 3.00;
                break;
            case "pineapple":
                priceOfProduct = 5.60;
                break;
            case "grapes":
                priceOfProduct = 4.20;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}

double totalPrice = quantity * priceOfProduct;

if(totalPrice > 0)
{
   Console.WriteLine($"{totalPrice:f2}");
}

