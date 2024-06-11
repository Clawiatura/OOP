//1.Составить описание класса для представления времени. Предусмотреть возможности установки времени и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений. В случае недопустимых значений полей выбрасываются исключения. Создать методы изменения времени на заданное количество часов, минут и секунд.
//2.	Описать класс, представляющий треугольник. Предусмотреть методы для создания объектов, вычисления площади, периметра и точки пересечения медиан. Описать методы для получения состояния объекта.
//using OOPls2;

//Time time = new Time(1,1,1);
//Console.WriteLine(time);// не знаю как сделать, чтобы выводил время указанное выше :(


//Console.WriteLine("Введите кол-во часов:");
//int hours = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите кол-во минут: ");
//int minutes = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите кол-во секунд: ");
//int seconds = int.Parse(Console.ReadLine());

//time.newTimeHour(hours);
//time.newTimeMintes(minutes);
//time.newTimeSecond(seconds);
//Console.WriteLine(time);

//2.Описать класс, представляющий треугольник. Предусмотреть методы для создания объектов, вычисления площади, периметра и точки пересечения медиан. Описать методы для получения состояния объекта.

//Я взял равносторонний треугольник


using OOPls2;

Maths maths = new Maths();
Console.WriteLine("Введите длину стороны: ");
double x = double.Parse(Console.ReadLine());
maths.P(x);
Console.WriteLine($"P={maths.P(x)}");
maths.S(x);
Console.WriteLine($"S={maths.S(x)}");
maths.mediana(x);
Console.WriteLine($"Mediana={maths.mediana(x)}");

