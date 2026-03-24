namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
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