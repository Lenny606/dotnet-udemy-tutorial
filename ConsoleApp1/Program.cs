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
        
        Console.WriteLine($"Average temperature: {GetAvgTemp(temp)}");


    }
    
    
    static double GetAvgTemp(int[] temp)
    {
        return temp.Average();
    }
}