using Generics;

Teacher<string, string, string> teacher = new Teacher<string, string, string>
{
    Address = "qqqqq",
    Age = 40,
    EyesColor = "Green",
    Gender = "Male",
    Height = 90,
    Id = 1,
    Name = "Василий",
    Phone = "+790067884534",
    Position = "Учитель",
    Rassa = "Европа",
    Rost = 190,
    Salary = 45000,
    Stage = 10,
    Subject = "Физика",
    WorkStart = new DateTime(2000, 12, 3)
};

Manager<string, string, string> manager = new Manager<string, string, string>
{
    Address = "zxc",
    Age = 40,
    EyesColor = "blue",
    Gender = "Male",
    Stage = 2,
    Name = "Petr"

};
Programmer<string, string, string> programmer = new Programmer<string, string, string>
{
    Name = "Vova",
    Age = 40,
    Language = "Java",
    Specialization = "Devopler",
    Projects = new List<string>(),
    
    

};
programmer.Projects.Add("google");
programmer.Projects.Add("yandex");