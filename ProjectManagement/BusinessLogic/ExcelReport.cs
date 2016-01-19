using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace BusinessLogic
{
    public class ExcelReport
    {
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void createReport()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Range chartRange;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Columns.AutoFit();


            xlWorkSheet.get_Range("A1", "C1").Merge(false);
            xlWorkSheet.get_Range("A1", "C1").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A1").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A1").Cells.FormulaR1C1 = "TRƯỜNG ĐH CÔNG NGHỆ THÔNG TIN";
            xlWorkSheet.Cells[1, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.get_Range("A2", "C2").Merge(false);
            xlWorkSheet.get_Range("A2", "C2").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A2").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A2").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A2").Cells.FormulaR1C1 = "PHÒNG ĐÀO TẠO ĐẠI HỌC";
            xlWorkSheet.Cells[2, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.get_Range("A4", "E4").Merge(false);
            xlWorkSheet.get_Range("A4", "E4").Cells.Font.Size = 20;
            xlWorkSheet.get_Range("A4").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A4").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A4").Cells.FormulaR1C1 = "BẢNG ĐIỂM CUỐI KỲ";
            xlWorkSheet.Cells[4, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.get_Range("A5", "C5").Merge(false);
            xlWorkSheet.get_Range("A5", "C5").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A5").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A5").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A5").Cells.FormulaR1C1 = "HỌC KỲ: ";
            xlWorkSheet.get_Range("A5").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            xlWorkSheet.get_Range("D5", "E5").Merge(false);
            xlWorkSheet.get_Range("D5", "E5").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("D5").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("D5").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("D5").Cells.FormulaR1C1 = "NĂM HỌC: ";

            xlWorkSheet.get_Range("F5", "G5").Merge(false);
            xlWorkSheet.get_Range("F5", "G5").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("F5").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("F5").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("F5").Cells.FormulaR1C1 = "Trọng số: ";

            xlWorkSheet.get_Range("A6", "C6").Merge(false);
            xlWorkSheet.get_Range("A6", "C6").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A6").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A6").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A6").Cells.FormulaR1C1 = "Môn học: ";

            xlWorkSheet.get_Range("D6", "E6").Merge(false);
            xlWorkSheet.get_Range("D6", "E6").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("D6").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("D6").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("D6").Cells.FormulaR1C1 = "Lớp: ";

            xlWorkSheet.get_Range("F6", "G6").Merge(false);
            xlWorkSheet.get_Range("F6", "G6").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("F6").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("F6").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("F6").Cells.FormulaR1C1 = "Ngày thi: ";

            xlWorkSheet.get_Range("A7", "C7").Merge(false);
            xlWorkSheet.get_Range("A7", "C7").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A7").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A7").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A7").Cells.FormulaR1C1 = "Giảng viên: ";

            xlWorkSheet.get_Range("D7", "E7").Merge(false);
            xlWorkSheet.get_Range("D7", "E7").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("D7").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("D7").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("D7").Cells.FormulaR1C1 = "Mã giảng viên: ";


            xlWorkSheet.get_Range("F7", "G7").Merge(false);
            xlWorkSheet.get_Range("F7", "G7").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("F7").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("F7").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("F7").Cells.FormulaR1C1 = "Phòng thi: ";

            //Mark table

            xlWorkSheet.get_Range("A10", "F10").Cells.Font.Size = 16;
            xlWorkSheet.get_Range("A10", "F10").Cells.Font.Name = "Times New Roman";
            xlWorkSheet.get_Range("A10", "F10").Cells.Font.Bold = true;
            xlWorkSheet.get_Range("A10").Cells.EntireColumn.ColumnWidth = 8;
            xlWorkSheet.get_Range("B10").Cells.EntireColumn.ColumnWidth = 30;
            xlWorkSheet.get_Range("C10").Cells.EntireColumn.ColumnWidth = 45;
            xlWorkSheet.get_Range("D10").Cells.EntireColumn.ColumnWidth = 15;
            xlWorkSheet.get_Range("E10").Cells.EntireColumn.ColumnWidth = 25;
            xlWorkSheet.get_Range("F10").Cells.EntireColumn.ColumnWidth = 20;
            xlWorkSheet.get_Range("A10", "F10").Cells.EntireColumn.AutoFit();
            xlWorkSheet.get_Range("A10", "F10").Cells.EntireRow.AutoFit();

            xlWorkSheet.Cells[10, 1] = "STT";
            xlWorkSheet.Cells[10, 2] = "MSSV";
            xlWorkSheet.Cells[10, 3] = "Họ tên sinh viên";
            xlWorkSheet.Cells[10, 4] = "Điểm số";
            xlWorkSheet.Cells[10, 5] = "Điểm chữ";
            xlWorkSheet.Cells[10, 6] = "Ghi chú";

            xlWorkSheet.get_Range("A11", "F11").Cells.Font.Size = 14;
            xlWorkSheet.get_Range("A11", "F11").Cells.Font.Name = "Times New Roman";


            //Read data file here
            xlWorkSheet.Cells[11, 1] = "1";
            xlWorkSheet.Cells[11, 2] = "12520001";
            xlWorkSheet.Cells[11, 3] = "Nguyễn Tuấn Anh";
            xlWorkSheet.Cells[11, 4] = "9.0";
            xlWorkSheet.Cells[11, 5] = "Chín";
            xlWorkSheet.Cells[11, 6] = "";

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Excel file(*.xls)|*.xls";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) { return; }

                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                MessageBox.Show("Excel file created success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel file created fail");
            }
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
    }
}
