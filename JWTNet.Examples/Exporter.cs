using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JWTNet.Examples
{
    public class Exporter
    {
        private static string WORKSHEET= "Hoja";

        public Byte[] Export()
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add(Exporter.WORKSHEET);
                int row = 3;

                var worksheet = excel.Workbook.Worksheets[WORKSHEET];

                worksheet.Cells[1, 1].Value = "Listado de automoviles";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells["A1:D1"].Merge = true;

                worksheet.Cells[3, 1].Style.Font.Bold = true;
                worksheet.Cells[3, 2].Style.Font.Bold = true;
                worksheet.Cells[3, 3].Style.Font.Bold = true;
                worksheet.Cells[3, 4].Style.Font.Bold = true;

                worksheet.Cells[3, 1].Value = "Modelo";
                worksheet.Cells[3, 2].Value = "Patente";
                worksheet.Cells[3, 3].Value = "KM";
                worksheet.Cells[3, 4].Value = "Marca";

                row++;

                var data = new List<int>();
                data.Add(1);
                data.Add(2);
                data.Add(3);
                data.Add(4);

                foreach (var item in data)
                {
                    worksheet.Cells[row, 1].Value = item;
                    worksheet.Cells[row, 2].Value = item;
                    worksheet.Cells[row, 3].Value = item;
                    worksheet.Cells[row, 4].Value = item;

                    row++;
                }

                worksheet.Name = "Automoviles";
                worksheet.Cells.AutoFitColumns();

                string path = @"C:\test\test.xlsx";
                Stream stream = File.Create(path);
                excel.SaveAs(stream);
                stream.Close();
           

                return excel.GetAsByteArray();

            }
        }
    }
}
