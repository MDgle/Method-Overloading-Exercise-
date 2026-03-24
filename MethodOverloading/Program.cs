namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 3));
            Console.WriteLine(Add(5.5m, 3.2m));
            Console.WriteLine(Add(5, 3, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(5, 3, false));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        static string Add(int a, int b, bool includeCurrency)
        {
            var sum = a + b;
            if (includeCurrency)
            {
                if (sum == 1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}