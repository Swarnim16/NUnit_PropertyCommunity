using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace PropertyCommunity_Project.DataDriven
{
    class ExcelFileHandler
    {
        String fileName = @"C:\Users\Vineet\source\repos\PropertyCommunity_Solution\PropertyCommunity_Project\DataDriven\TestData.xlsx";
        public Excel.Application applicationExcel = null;
        public Excel.Workbook workbookExcel = null;
        public Excel._Worksheet worksheetExcel = null;

        public String selectProperty = "";
        public DateTime dueDate;
        public String selectTenant = "";
        public String description = "";

        public void GetInspectionRequestInput()
        {
            //String propertyName = ""; 
            try
            {
                applicationExcel = new Excel.Application();
                workbookExcel = applicationExcel.Workbooks.Open(fileName);
                worksheetExcel = workbookExcel.Sheets[1];
                Excel.Range range = worksheetExcel.UsedRange;
                int rowCount = 0;
                for(rowCount=2;rowCount<= range.Rows.Count; rowCount++)
                {
                    selectProperty = (range.Cells[rowCount, 1] as Excel.Range).Text;
                    selectTenant= (range.Cells[rowCount, 2] as Excel.Range).Text;
                    String dt = (range.Cells[rowCount, 3] as Excel.Range).Value2.ToString();
                    double date = double.Parse(dt);
                    dueDate = DateTime.FromOADate(date);
                    description= (range.Cells[rowCount, 4] as Excel.Range).Text;

                }

            }
            catch(Exception ex)
            { }
        }

        public void closeAllObject()
        {

            workbookExcel.Close(false);
            applicationExcel.Quit();
        }
        


    }
}
