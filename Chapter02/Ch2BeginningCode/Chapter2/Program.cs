namespace Packt.CloudySkiesAir.Chapter2;

internal class Program
{
    private static void Main()
    {
        int numChecked = 2;
        int numCarryOn = 1;
        int numPassengers = 2;

        BaggageCalculator baggageCalculator = new();
        DateTime travelTime = DateTime.Now;
        //將容易變動的是否為假日條件改為方法的傳入參數
        decimal price = baggageCalculator.CalculatePrice(numChecked, numCarryOn, numPassengers, travelTime.Month >= 11 || travelTime.Month <= 2);

        Console.WriteLine($"{numChecked} checked and {numCarryOn} carry-on bags for {numPassengers} passengers is {price:C}");
    }
}