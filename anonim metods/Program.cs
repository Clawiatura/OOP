Func <int,int,int> sum = delegate (int a,int b) { return a + b; };
int result = sum(5, 3);

Console.WriteLine(result);

string[] sss = { "Apple", "Barakus", "Alpa", "Perrr" };
var filter = sss.Where(w => w.StartsWith('A')).ToArray();

foreach (var item in filter)
{
    Console.WriteLine(item);
}


Func<int, int, int>[] oper =
{
    (a,b) => a + b,
    (a,b) => a - b,
    (a,b) => a * b,
    (a,b) => a / b,
};
Console.WriteLine("Введите числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Выберите операцию: 0 - сложение, 1 - вычитание, 2 - умножение, 3 - деление");
int operation = int.Parse(Console.ReadLine());

int resultats = oper[operation](num1,num2);
Console.WriteLine(resultats);


