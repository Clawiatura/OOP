using Абстракнные_классы;

List<Animal> animals = new List<Animal>();
animals.Add(new Omnivores("Hominids",300));
animals.Add(new Omnivores("pigs",200));
animals.Add(new Omnivores("bears",400));
animals.Add(new Omnivores("deer",500));
animals.Add(new Omnivores("badgers", 400));
animals.Add(new Herbivorous("tiger",150));
animals.Add(new Herbivorous("Cow", 250));
animals.Add(new Herbivorous("Horse", 350));
animals.Add(new Herbivorous("Sheep", 150));
animals.Add(new Herbivorous("Rabbit", 150));
animals.Add(new Predator("fox", 200));
animals.Add(new Predator("Hyena", 300));
animals.Add(new Predator("dolpgin", 100));
animals.Add(new Predator("dog", 400));
animals.Add(new Predator("Tiger", 500));


for (int i = 0; i < animals.Count - 1; i++)
{
    for (int j = i + 1; j < animals.Count; j++)
    {
        if (animals[i].Eats > animals[j].Eats)
            (animals[i], animals[j]) = (animals[j], animals[i]);
    }
}
foreach (var animal in animals)
{
    Console.WriteLine($"Животное: {animal.Name}, Кол-во еды: {animal.Eats}");
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Имя: {animals[i].Name}");
}
for (int i = animals.Count - 3; i < animals.Count; i++)
{
    Console.WriteLine($"Идентификатор: {animals[i].Name}");
}

File.Exists("\"D:\\zxc\\animal.txt");

string info = File.ReadAllText("D:\\zxc\\animal.txt");

Console.WriteLine(info);
















