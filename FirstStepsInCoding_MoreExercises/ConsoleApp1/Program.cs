namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double skumriaPrice = double.Parse(Console.ReadLine());
            double tsatsaPrice = double.Parse(Console.ReadLine());
            double palamudKilogram = double.Parse(Console.ReadLine());
            double safridKilogram = double.Parse(Console.ReadLine());
            double midiKilogram = double.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice + skumriaPrice * 0.60;
            double safridPrice = tsatsaPrice + tsatsaPrice * 0.80;
            double midiPrice = 7.50;

            double palamudSum = palamudKilogram * palamudPrice;
            double safridSum = safridKilogram * safridPrice;
            double midiSum = midiKilogram * midiPrice;

            double totalSum = palamudSum + safridSum + midiSum;

            Console.WriteLine("{0:F2}", totalSum);



        }
    }
}
