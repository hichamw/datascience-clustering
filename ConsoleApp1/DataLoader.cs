using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.HSSF.Record.Chart;
using NPOI.XSSF.UserModel;

namespace ConsoleApp1
{
    public class DataLoader
    {
        

        //FILE PATH:

        public void LoadPivot()
        {
            var filePath = "./WineKMC.xlsx";
            var csvFilePath = "./PivotSnippet.csv";
            
            XSSFWorkbook workbook = new XSSFWorkbook(new FileStream(filePath, FileMode.Open));
            XSSFSheet sheet = workbook.GetSheet("pivot") as XSSFSheet;
            var csv = new StringBuilder();

            for (int row = 3; row < 36; row++)
            {
                var line = "";
                
                for (int cell = 0; cell < 101; cell++)
                {
                    if (row == 3)
                    {
                        line += sheet.GetRow(row).GetCell(cell).StringCellValue + ',';
                    }
                    else
                    { 
                        line += sheet.GetRow(row).GetCell(cell).NumericCellValue.ToString() + ',';
                    }
                }
                csv.AppendLine(line);
            }
            File.WriteAllText(csvFilePath, csv.ToString());

        }
    }
}