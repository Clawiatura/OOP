using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        var fileInfo = new FileInfo("Календарь_2023.xlsx");
        using (var package = new ExcelPackage(fileInfo))
        {
            var worksheet = package.Workbook.Worksheets.Add("Календарь 2023");

            
            for (int month = 1; month <= 12; month++)
            {
                worksheet.Cells[1, month].Value = new DateTime(2023, month, 1).ToString("MMMM");
                int dayCounter = 1;
                int row = 2; 

                
                var firstDay = new DateTime(2023, month, 1);
                int startDay = (int)firstDay.DayOfWeek;

                
                for (int i = 0; i < startDay; i++)
                {
                    worksheet.Cells[row, month].Value = "";
                    row++;
                }

                for (int day = 1; day <= DateTime.DaysInMonth(2023, month); day++)
                {
                    var cell = worksheet.Cells[row, month];
                    cell.Value = day;

                    
                    var date = new DateTime(2023, month, day);
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        cell.Style.Font.Bold = true;
                    }

                    row++; 
                }
            }

            package.Save();
        }
    }
}