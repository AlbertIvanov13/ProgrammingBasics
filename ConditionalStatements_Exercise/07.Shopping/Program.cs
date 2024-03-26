double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int proccessors = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());

double videoCardsQuantity = videoCards * 250;
double proccessorsQuantity = (videoCardsQuantity * 0.35) * proccessors;
double ramMemoryQuantity = (videoCardsQuantity * 0.10) * ramMemory;

double totalSum = videoCardsQuantity + proccessorsQuantity + ramMemoryQuantity;

if (videoCards > proccessors)
{
    totalSum -= totalSum * 0.15;
}

if (totalSum <= budget)
{
    Console.WriteLine($"You have {Math.Abs(budget - totalSum):f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(totalSum - budget):f2} leva more!");
}