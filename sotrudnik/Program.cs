using sotrudnik;
Tusk tusk = new Tusk();
var employees = new List<Employee>

{
new Employee { id = 1, name = "Ivan", Tusks = new List<Tusk> { new Tusk { TitleName = "Title 1", DateEnd = DateTime.Now.AddDays(1), Priority = "low" } } },
new Employee { id = 2, name = "Petr", Tusks = new List<Tusk> { new Tusk { TitleName = "Title 2", DateEnd = DateTime.Now.AddDays(2), Priority = "high" } } }
};
employees.Sort();
foreach (var emp in employees)
{
    Console.WriteLine($"Employee: {emp.name}, Id: {emp.id}");
    foreach (var clnTusk in emp)
    {
        var clonedTusk = (Tusk)tusk.Clone();
        Console.WriteLine($"  Task: {clonedTusk.TitleName}, Priority: {clonedTusk.Priority}, Due Date: {clonedTusk.DateEnd}");
    }
}




