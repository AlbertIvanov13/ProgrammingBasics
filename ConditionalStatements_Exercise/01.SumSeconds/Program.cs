int playerOneSeconds = int.Parse(Console.ReadLine());   
int playerTwoSeconds = int.Parse(Console.ReadLine());   
int playerThreeSeconds = int.Parse(Console.ReadLine());

int totalTime = playerOneSeconds + playerTwoSeconds + playerThreeSeconds;

int minutes = totalTime / 60;
int seconds = totalTime % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:{seconds:d2}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}

