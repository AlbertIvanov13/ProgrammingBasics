using Microsoft.VisualBasic;

double tripPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double puzzlesPrice = puzzles * 2.60;
double dollsPrice = dolls * 3;
double bearsPrice = bears * 4.10;
double minionsPrice = minions * 8.20;
double trucksPrice = trucks * 2;

double totalPrice = puzzlesPrice 
                   + dollsPrice 
                   + bearsPrice 
                   + minionsPrice 
                   + trucksPrice;

double toysQuantity = puzzles + dolls + bears + minions + trucks;

if (toysQuantity >= 50)
{
    totalPrice -= totalPrice * 0.25;
}

totalPrice -= totalPrice * 0.1;

if (totalPrice >= tripPrice)
{
    double remainingMoney = totalPrice - tripPrice;
    Console.WriteLine($"Yes! {remainingMoney:f2} lv left.");
}
else
{
    double neededMoney = tripPrice - totalPrice;
    Console.WriteLine($"Not enough money! {Math.Abs(neededMoney):f2} lv needed.");
}