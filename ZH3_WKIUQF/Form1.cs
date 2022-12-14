using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace ZH3_WKIUQF
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");


                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;

            }
        }

            void CreateTable()
            {
                string[] fejlecek = new string[]
                {
                 "K�rd�s",
                "V�lasz1",
                "V�lasz2",
                "V�lasz3",
                "Helyes v�lasz",
                "k�p"
                };

            for (int i = 0; i < fejlecek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlecek[i];
            }

            Models.HajosContext context = new Models.HajosContext();
            var kerdesek = context.Questions.ToList();

            object[,] adatok = new object[kerdesek.Count(), fejlecek.Count()];

            for (int i = 0; i < kerdesek.Count(); i++)
            {
                adatok[i, 0] = kerdesek[i].Question1;
                adatok[i, 1] = kerdesek[i].Answer1;
                adatok[i, 2] = kerdesek[i].Answer2;
                adatok[i, 3] = kerdesek[i].Answer3;
                adatok[i, 4] = kerdesek[i].CorrectAnswer;
                adatok[i, 5] = kerdesek[i].Image;
            }

            int sorokSz�ma = adatok.GetLength(0);
            int oszlopokSz�ma = adatok.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSz�ma, oszlopokSz�ma);
            adatRange.Value2 = adatok;

            adatRange.Columns.AutoFit();

            Excel.Range headerRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 30;
            headerRange.Interior.Color = Color.BlueViolet;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }

    }
}