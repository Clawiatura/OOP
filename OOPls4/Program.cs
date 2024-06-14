using OOPls4;

//Vagonetka vagon1 = new Vagonetka(1,"pervui class",50 );
//Vagonetka vagon2 = new Vagonetka(2,"bizness class",33);
//vagon1.exit(33);
//vagon1.sell(12);

//vagon2.sell(12);
//vagon1.exit(11);

//vagon1.Current();
//vagon2.Current();

Rocket rocket1 = new Rocket("benzin", 30.0, 102000.2, 2111111.2);
Rocket rocket2 = new Rocket("dizel", 30.1, 111.2, 11.2);
Console.WriteLine("Введите время: ");
double time = double.Parse(Console.ReadLine());
rocket1.speedRocket(time);
rocket1.Orbit();



rocket1.stageD(time);
