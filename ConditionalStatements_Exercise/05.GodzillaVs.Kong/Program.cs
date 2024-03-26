double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double clothingPrice = double.Parse(Console.ReadLine());

double decorSum = budget * 0.10;
double clothingSum = statists * clothingPrice;

if (statists > 150)
{
    clothingSum -= clothingSum * 0.10;
}

double totalSum = decorSum + clothingSum;

if (totalSum <= budget)
{
    double remaininжMoney = budget - totalSum;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {remaininжMoney:f2} leva left.");
}
else if (totalSum > budget)
{
    double neededMoney = totalSum - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
}