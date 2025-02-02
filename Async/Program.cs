using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        
        Task<long> factorialTask = FactorialAsync(5);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            await Task.Delay(1000); 
        }

        long result = await factorialTask; 
        Console.WriteLine($"Факториал: {result}");
    }

    static async Task<long> FactorialAsync(int number)
    {
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            await Task.Delay(1000); 
            result *= i;
            if (i == 5) 
            {
                Console.WriteLine($"Факториал {i}: {result}");
            }
        }
        return result;
    }
}