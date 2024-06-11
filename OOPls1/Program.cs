using OOPls1;
using System.Runtime.Serialization;
using System.Security.Principal;
Operations operations = new Operations();
Console.WriteLine("Введите три значения:");
for (int i = 0; i < 3; i++)
    {
    string value = Console.ReadLine();
    operations.AddValue(value);
}
Console.WriteLine("Список");
foreach (string value in operations.values)
{
    Console.WriteLine(value);
}



Console.WriteLine("Выберите действие:\\1. Удалить элемент\\2. Поиск значения\\3. Очистить список\\4. Сортировать список\\\\5. Вычислить сумму чисел\\6. Найти минимальное значение\\7. Найти максимальное значение");
int number = int.Parse(Console.ReadLine()!);
switch(number)
{
    case 1:
        {
            
            Console.WriteLine("Введите индекс для удаления: ");
            
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            operations.Delete(index);
            foreach (string value in operations.values)
            {
                Console.WriteLine(value);
            }


        }
        break;
    case 2: 
        {
            Console.WriteLine("Введите значение для поиска: ");
            string Values = Console.ReadLine();
            int index = operations.FindValue(Values);
            if(index != -1)
            {
                Console.WriteLine($"Первое вхождение по индексу {index}") ;
            }
            else
            {
                Console.WriteLine("Введите другое значение");
            }
        }
        break;
    case 3: 
        {
            operations.Clear();
            
        }
        break;
    case 4:
        {
            operations.Sort();
            foreach(string value in operations.values)
            {
                Console.WriteLine(value);
            }
            
        }
        break;
    case 5:
        {
            int sum = operations.Sum();
                Console.WriteLine($"{sum}");
        }
        break;
    case 6:
        {
            int min = operations.min();
            Console.WriteLine(min);
        }
        break;
    case 7:
        {
            int max = operations.max();
            Console.WriteLine(max);
        }
        break;

        default:
        {
            Console.WriteLine("Неверный выбор");

        }
        break;

}