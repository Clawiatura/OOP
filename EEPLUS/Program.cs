using System;
using System.Collections.Generic;
using System.Xml.Linq;
using OfficeOpenXml;


public class Client
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Client(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}

class Program
{
    static void Main()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // без этой строки была ошибка, начал гуглить и с этой строкой все заработало
        var clients = new List<Client>
        {
            new Client("Иван", "Иванов", "ivan@example.com"),
            new Client("Петр", "Петров", "peter@example.com"),
            new Client("Мария", "Сидорова", "maria@example.com"),
            new Client("Анна", "Кузнецова", "anna@example.com"),
            new Client("Алексей", "Смирнов", "alex@example.com"),
            new Client("Наталья", "Васильева", "natalia@example.com"),
            new Client("Сергей", "Морозов", "sergey@example.com"),
            new Client("Ольга", "Павлова", "olga@example.com"),
            new Client("Денис", "Жуков", "denis@example.com"),
            new Client("Екатерина", "Макарова", "ekaterina@example.com"),
        };

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Клиенты");
            worksheet.Cells[1, 1].Value = "Имя";
            worksheet.Cells[1, 2].Value = "Фамилия";
            worksheet.Cells[1, 3].Value = "Email";

            for (int i = 0; i < clients.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = clients[i].FirstName;
                worksheet.Cells[i + 2, 2].Value = clients[i].LastName;
                worksheet.Cells[i + 2, 3].Value = clients[i].Email;
            }

            package.SaveAs(new FileInfo("СписокКлиентов.xlsx"));
        }
    }
}