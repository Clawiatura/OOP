using Animals;

var animals = new Anima<Pet>();
animals.add(new Pet(1, "Pes", "Korgi", DateTime.Now, 3));
var allAnimals = animals.get();

foreach (var animal in allAnimals)
{
    Console.WriteLine($"{animal.NickName}, {animal.Breed}, {animal.Age} года");
}
