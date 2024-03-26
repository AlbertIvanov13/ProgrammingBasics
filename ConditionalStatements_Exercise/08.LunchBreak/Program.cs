string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchTime = (double)breakDuration /8;
double relaxTime = (double)breakDuration /4;

double remainingTime = breakDuration - lunchTime - relaxTime;
double neededMinutes = episodeDuration - remainingTime;

if (remainingTime >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - episodeDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(neededMinutes)} more minutes.");
}