using sotrudnik;
Tusk tusk = new Tusk { TitleName = "Вывоз Мусора", DateEnd = DateTime.Today, Priority = "Средний"};
Employee employee = new Employee { name = "Ivan", id = 3, Employees = };
//employee.Employees.Add(tusk);

Tusk tuskToo = new Tusk { TitleName = "Уборка квартир", DateEnd = DateTime.Today, Priority = "Низкий" };
Employee employeeToo = new Employee { name = "Grih", id = 2 };
//employeeToo.Employees.Add(tuskToo);

IEnumerable<Employee> employees = new List<Employee>();



