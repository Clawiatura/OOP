using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;

FileInfo fileInfo = new FileInfo("Календарь " + DateTime.Now.Year + ".xlsx");

ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(fileInfo);

var worksheet = newBook.Workbook.Worksheets.Add("Календарь " + DateTime.Now.Year);

string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

for (int month = 1; month < 12; month++)
{
    //название месяца
    worksheet.Cells[1, month + 1].Value = months[month];
    worksheet.Cells[1, month + 1].Style.Font.Bold = true;


    DateTime firstDay = new DateTime(DateTime.Now.Year, month + 1, 1);

    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month + 1);

    // дни
    for (int day = 1; day <= daysInMonth; day++)
    {
        DateTime currentDate = new DateTime(DateTime.Now.Year, month + 1, day);
        int row = day + 1;


        worksheet.Cells[row, month + 1].Value = day;
        worksheet.Cells[row, month + 1].AddComment(currentDate.DayOfWeek.ToString());

        //выходные

        if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
        {
            worksheet.Cells[row, month + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[row, month + 1].Style.Fill.BackgroundColor.SetColor(Color.Violet);
            worksheet.Cells[row, month + 1].Style.Font.Bold = true;
        }
    }
}
try
{
    newBook.Save();
    Console.WriteLine("Календарь успешно создан!");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
}
