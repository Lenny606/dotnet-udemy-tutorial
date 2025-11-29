namespace DotnetUdemy;

class Test
{
    static int _result;//field is instance

    static void Main(string[] args)
    {
        static void Add(int a, int b)
        {
            _result = a + b;
            // return _result;
        }

        static void PrintResult()
        {
            Add(5, 4);
            Console.WriteLine(_result);
        }
        PrintResult();
    }
}