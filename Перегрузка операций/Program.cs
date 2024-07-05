using Перегрузка_операций;

Vector v1 = new Vector(1,2,3);
Vector v2 = new Vector(2,3,4);

Vector  sum = v1 + v2;
Vector raz = v2 - v1;
double sklProizv = v1 * v2;
double lenght = v1.Length();
double cos = v1.Cos(v2);

Console.WriteLine("Сумма векторов: ({0}, {1}, {2})", sum.X, sum.Y, sum.Z);
Console.WriteLine("Разность векторов: ({0}, {1}, {2})", raz.X, raz.Y, raz.Z);
Console.WriteLine(sklProizv);
Console.WriteLine(lenght);
Console.WriteLine(cos);

