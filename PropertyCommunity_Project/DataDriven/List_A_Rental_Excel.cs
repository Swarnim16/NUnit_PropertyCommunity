using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace PropertyCommunity_Project.DataDriven
{
    public class List_A_Rental_Excel
    {
        public static String selectProperty = "";
        public static String title = "";
        public static int movingCost = 0;
        public static int targetRent = 0;
        public static DateTime availableDate;
        public static int occupantsCount = 0;
        public static String description = "";

        static String fileName = @"C:\Users\Vineet\source\repos\PropertyCommunity_Solution\PropertyCommunity_Project\DataDriven\List_A_Rental(InputData).xlsx";
        static Excel.Application application = null;
        static Excel.Workbook workbook = null;
        static Excel._Worksheet worksheet = null;


        public static void getRentalInput()
        {

            try
            {
                application = new Excel.Application();
                //workbooks = application.Workbooks;
                workbook = application.Workbooks.Open(fileName);
                worksheet = workbook.Sheets[1];
                Excel.Range range = worksheet.UsedRange;
                int rowCount = 0;
                for (rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
                {
                    selectProperty = (range.Cells[rowCount, 1] as Excel.Range).Text;
                    title = (range.Cells[rowCount, 2] as Excel.Range).Text;
                    movingCost = Convert.ToInt32((range.Cells[rowCount, 3] as Excel.Range).Text);
                    targetRent = Convert.ToInt32((range.Cells[rowCount, 4] as Excel.Range).Text);
                    String dt = (range.Cells[rowCount, 5] as Excel.Range).Value2.ToString();
                    double date = double.Parse(dt);
                    DateTime avDate = DateTime.FromOADate(date);
                    availableDate = avDate;
                    //Convert.ToDateTime((range.Cells[rowCount, 5] as Excel.Range).Text);
                    occupantsCount = Convert.ToInt16((range.Cells[rowCount, 6] as Excel.Range).Text);
                    description = (range.Cells[rowCount, 7] as Excel.Range).Text;

                }
                //workbook.Close();
                //application.Quit();

            }
            catch(Exception ex)
            {

                throw ex;
            }
            finally
            {
                //workbook.Close();
                //application.Quit();
            }
    
        }
        public static void closeAllObject()
        {

            workbook.Close(false);
            application.Quit();
        }
    }
}
