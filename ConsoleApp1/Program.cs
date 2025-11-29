namespace ConsoleApp1;

//WEATHER PROJECT
class Program
{
    static int days;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of days: ");
       
        var ok = int.TryParse(Console.ReadLine(), out days);
        
        if (!ok)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int[] temp = new int[days];
        string[] conditions = { "Rainy", "Sunny", "Snowy" };
        string[] actualConditions = new string[days];
        
        Random rnd = new Random();

        for (int i = 0; i < days; i++)
        {
            temp[i] = rnd.Next(-10, 30);
            actualConditions[i] = conditions[rnd.Next(conditions.Length)];
        }

        CountDown(days);
        
        Console.WriteLine($"Average temperature: {GetAvgTemp(temp)}");
        Console.WriteLine($"Minimum temperature: {GetMinTemp(temp)}");
        Console.WriteLine($"Maximum temperature: {GetMaxTemp(temp)}");
        Console.WriteLine($"Most common cond: {GetMostCommonCondition(actualConditions)}");


    }
    static string GetMostCommonCondition(string[] conditions)
    {
        
        return conditions.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
    }
    
    static int GetMinTemp(int[] temp)
    {
        return temp.Min();
    }
    static int GetMaxTemp(int[] temp)
    {
        return temp.Max();
    }

    static void CountDown(int num)
    {
        if (num <= 0)
        {
            Console.WriteLine("Starting calculating weather data...");
            return;
        }

        Console.WriteLine("Ccounting down: {0}", num);
        
        CountDown(num - 1);
    }
    
    static double GetAvgTemp(int[] temp)
    {
        return temp.Average();
    }
}