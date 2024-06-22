//1.Создать класс Liquid(жидкость), имеющий поля названия и плотности. 
//    Определить методы переназначения и изменения плотности.
//    Создать производный класс Alcohol (спирт), имеющий крепость.
//    Определить методы переназначения и изменения крепости.
//2.	Создать класс Pair (пара чисел); 
//определить методы изменения полей и вычисления произведения чисел. 
//    Определить производный класс Rectangle (прямоугольник) с полями-сторонами. 
//    Определить методы вычисления периметра и площади прямоугольника.
using OOPls9;



//Luquid luquid = new Luquid { name = "vodka", plotnost = 29.99};

//Console.WriteLine("Введите новую плотность Водки");
//double plt = double.Parse(Console.ReadLine());
//luquid.NewPlotnost(plt);
//Luquid.Alcohol alcohol = new Luquid.Alcohol { name = "tekila", plotnost = 29.99, plotnostSpirt = 39.99 };
//Console.WriteLine("Введите новую плотность tekila");
//double pltspirt = double.Parse(Console.ReadLine());
//alcohol.NewPlotnost(pltspirt);

Pair pair = new Pair { x = 3.44, y = 5.55 };

Console.WriteLine(pair.proizv());

Pair.Rectagle rect = new Pair.Rectagle { loong = 34.44, shoort = 22.22 };
rect.sRestagle();
rect.pRestagle();