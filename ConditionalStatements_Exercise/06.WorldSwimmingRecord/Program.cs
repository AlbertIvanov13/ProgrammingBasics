double record = double.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
double oneMeterSeconds = double.Parse(Console.ReadLine());

double neededSwimDistance = meters * oneMeterSeconds;
double addedSeconds = Math.Floor(meters / 15) * 12.5;

double totalTime = neededSwimDistance + addedSeconds;
double neededSeconds = totalTime - record;

if (record > totalTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {neededSeconds:f2} seconds slower.");
}