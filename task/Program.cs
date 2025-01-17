class Program
{
    static async Task Main(string[] args)
    {
       
        var sumTask = Task.Run(() => Sum(5, 10));

        
        Task.Run(() => PrintStory());

        
        Task.Run(() => CalculateFactorial(9));

        
        await Task.Run(() => WriteTextToFile("Каждый день на планете Гиперион был..."));

        
        int sum = await sumTask;
        Console.WriteLine($"Сумма: {sum}");
    }

    static int Sum(int a, int b) => a + b;

    static void PrintStory()
    {
        Console.WriteLine("На далекой планете в галактике Гиперион, где небеса были\r\nразукрашены яркими звездами и лазурными небесами, жили странные\r\nсущества, известные как блоглорпы. Блоглорпы были маленькими,\r\nпушистыми созданиями с шестиугольными глазами и тройными\r\nхвостами. Их домами были деревья, выращенные из кристаллов, и они\r\nпитались музыкой, которую производили цветы, растущие на дне их\r\nокеанов. Вечными друзьями блоглорпов были музыкальные киты,\r\nкоторые пели им мелодии о магии вселенной и тайнах времени.");
    }

    static void CalculateFactorial(int n)
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
            factorial *= i;
        Console.WriteLine($"Факториал {n}: {factorial}");
    }

    static void WriteTextToFile(string text)
    {
        File.WriteAllText("story.txt", text);
    }
}