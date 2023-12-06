using System.IO;
using ClosedXML.Excel;
using Aspose.Cells;
using System.Linq.Expressions;
using DocumentFormat.OpenXml.Office2013.Excel;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        double x1, x2, y1, y2, z1, z2, scalaranswer, vectoranswer1, vectoranswer2, vectoranswer3;
        bool scalar = false, vector = false;
        string message = "Заполните числами все ячейки!", title = "Ошибка", message1 = "Числа -0 не существует!";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vector == true || scalar == true)
            {
                excel();
                Workbook workbook = new Workbook("excel.xlsx");
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = sfd.FileName + ".xlsx";
                    workbook.Save(filepath, SaveFormat.Xlsx);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "-0" && textBox2.Text != "-0" && textBox3.Text != "-0" && textBox4.Text != "-0" && textBox5.Text != "-0" && textBox6.Text != "-0")
            {
                try
                {
                    scalar = false; vector = true;
                    x1 = Convert.ToDouble(textBox1.Text);
                    x2 = Convert.ToDouble(textBox4.Text);
                    y1 = Convert.ToDouble(textBox2.Text);
                    y2 = Convert.ToDouble(textBox5.Text);
                    z1 = Convert.ToDouble(textBox3.Text);
                    z2 = Convert.ToDouble(textBox6.Text);
                    vectoranswer1 = (y1 * z2 - z1 * y2);
                    vectoranswer2 = -(x1 * z2 - z1 * x2);
                    if (Convert.ToString(vectoranswer2) == "-0")
                        vectoranswer2 = 0;
                    vectoranswer3 = (x1 * y2 - y1 * x2);
                    vectoranswer1 = Math.Round(vectoranswer1, 10);
                    vectoranswer2 = Math.Round(vectoranswer2, 10);
                    vectoranswer3 = Math.Round(vectoranswer3, 10);
                    label9.Text = "(" + vectoranswer1 + " ; " + vectoranswer2 + " ; " + vectoranswer3 + ")";
                }
                catch
                {
                    MessageBox.Show(message, title);
                }
            }
            else
                MessageBox.Show(message1, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "-0" && textBox2.Text != "-0" && textBox3.Text != "-0" && textBox4.Text != "-0" && textBox5.Text != "-0" && textBox6.Text != "-0")
            {
                try
                {
                    vector = false; scalar = true;
                    x1 = Convert.ToDouble(textBox1.Text);
                    x2 = Convert.ToDouble(textBox4.Text);
                    y1 = Convert.ToDouble(textBox2.Text);
                    y2 = Convert.ToDouble(textBox5.Text);
                    z1 = Convert.ToDouble(textBox3.Text);
                    z2 = Convert.ToDouble(textBox6.Text);
                    scalaranswer = x1 * x2 + y1 * y2 + z1 * z2;
                    label9.Text = Convert.ToString(scalaranswer);
                }
                catch
                {
                    MessageBox.Show(message, title);
                }
            }
            else
                MessageBox.Show(message1, title);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (vector == true || scalar == true)
            {
                excel();
                Workbook workbook = new Workbook("excel.xlsx");

                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = sfd.FileName + ".docx";
                    workbook.Save(filepath, SaveFormat.Docx);

                }
            }

        }

        void excel()
        {
            if (scalar)
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Лист1");

                worksheet.Cell("A" + 1).Value = "Ответ:";
                worksheet.Cell("A" + 2).Value = "a · b = " + Convert.ToString(scalaranswer);
                worksheet.Cell("A" + 3).Value = "Ход решения";
                worksheet.Cell("A" + 4).Value = "Вычисляем по формуле: a · b = x1 · x2 + y1 · y2 + z1 · z2, соответственно";
                worksheet.Cell("A" + 5).Value = "a · b = " + x1 + " · " + x2 + " + " + y1 + " · " + y2 + " + " + z1 + " · " + z2 + " = " + x1 * x2 + " + " + y1 * y2 + " + " + z1 * z2;
                worksheet.Cell("A" + 6).Value = "И получаем ответ: " + scalaranswer;


                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                workbook.SaveAs("excel.xlsx");
            }
            if (vector)
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Лист1");

                worksheet.Cell("A" + 1).Value = "Ответ:";
                worksheet.Cell("A" + 2).Value = "a × b = ( " + vectoranswer1 + " ; " + vectoranswer2 + " ; " + vectoranswer3 + " )";
                worksheet.Cell("A" + 3).Value = "Вычисляем по формуле: a × b = ";
                worksheet.Cell("B" + 2).Value = "i";
                worksheet.Cell("C" + 2).Value = "j";
                worksheet.Cell("D" + 2).Value = "k";
                worksheet.Cell("F" + 2).Value = "y1";
                worksheet.Cell("G" + 2).Value = "z1";
                worksheet.Cell("I" + 2).Value = "x1";
                worksheet.Cell("J" + 2).Value = "z1";
                worksheet.Cell("L" + 2).Value = "x1";
                worksheet.Cell("M" + 2).Value = "y1";
                worksheet.Cell("B" + 3).Value = "x1";
                worksheet.Cell("C" + 3).Value = "y1";
                worksheet.Cell("D" + 3).Value = "z1";
                worksheet.Cell("E" + 3).Value = "=";
                worksheet.Cell("F" + 3).Value = "y2";
                worksheet.Cell("G" + 3).Value = "z2";
                worksheet.Cell("H" + 3).Value = "i - ";
                worksheet.Cell("I" + 3).Value = "x2";
                worksheet.Cell("J" + 3).Value = "z2";
                worksheet.Cell("K" + 3).Value = "j + ";
                worksheet.Cell("L" + 3).Value = "x2";
                worksheet.Cell("M" + 3).Value = "y2";
                worksheet.Cell("N" + 3).Value = "k";
                worksheet.Cell("B" + 4).Value = "x2";
                worksheet.Cell("C" + 4).Value = "y2";
                worksheet.Cell("D" + 4).Value = "z2";
                worksheet.Cell("B" + 6).Value = "i";
                worksheet.Cell("C" + 6).Value = "j";
                worksheet.Cell("D" + 6).Value = "k";
                worksheet.Cell("F" + 6).Value = y1;
                worksheet.Cell("G" + 6).Value = z1;
                worksheet.Cell("I" + 6).Value = x1;
                worksheet.Cell("J" + 6).Value = z1;
                worksheet.Cell("L" + 6).Value = x1;
                worksheet.Cell("M" + 6).Value = y1;
                worksheet.Cell("A" + 7).Value = "соответствено, a × b = ";
                worksheet.Cell("B" + 7).Value = x1;
                worksheet.Cell("C" + 7).Value = y1;
                worksheet.Cell("D" + 7).Value = z1;
                worksheet.Cell("E" + 7).Value = "=";
                worksheet.Cell("F" + 7).Value = y2;
                worksheet.Cell("G" + 7).Value = z2;
                worksheet.Cell("H" + 7).Value = "i - ";
                worksheet.Cell("I" + 7).Value = x2;
                worksheet.Cell("J" + 7).Value = z2;
                worksheet.Cell("K" + 7).Value = "j + ";
                worksheet.Cell("L" + 7).Value = x2;
                worksheet.Cell("M" + 7).Value = y2;
                worksheet.Cell("N" + 7).Value = "k =";
                worksheet.Cell("O" + 7).Value = "(" + y1 * z2 + " - " + z1 * y2 + ") - (" + x1 * z2 + " - " + z1 * x2 + ") + (" + x1 * y2 + " - " + y1 * x2 + ") = " + vectoranswer1 + " ; " + vectoranswer2 + " ; " + vectoranswer3;
                worksheet.Cell("B" + 8).Value = x2;
                worksheet.Cell("C" + 8).Value = y2;
                worksheet.Cell("D" + 8).Value = z2;
                worksheet.Cell("A" + 9).Value = "И получаем ответ: (" + vectoranswer1 + " ; " + vectoranswer2 + " ; " + vectoranswer3 + ")";
                var rngTable = worksheet.Range("B2:B" + 4);
                rngTable.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable1 = worksheet.Range("D2:D" + 4);
                rngTable1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable2 = worksheet.Range("F2:F" + 3);
                rngTable2.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable3 = worksheet.Range("G2:G" + 3);
                rngTable3.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable4 = worksheet.Range("I2:I" + 3);
                rngTable4.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable5 = worksheet.Range("J2:J" + 3);
                rngTable5.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable6 = worksheet.Range("L2:L" + 3);
                rngTable6.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable7 = worksheet.Range("M2:M" + 3);
                rngTable7.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable8 = worksheet.Range("B6:B" + 8);
                rngTable8.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable9 = worksheet.Range("D6:D" + 8);
                rngTable9.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable10 = worksheet.Range("F6:F" + 7);
                rngTable10.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable11 = worksheet.Range("G6:G" + 7);
                rngTable11.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable12 = worksheet.Range("I6:I" + 7);
                rngTable12.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable13 = worksheet.Range("J6:J" + 7);
                rngTable13.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                var rngTable14 = worksheet.Range("L6:L" + 7);
                rngTable14.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                var rngTable15 = worksheet.Range("M6:M" + 7);
                rngTable15.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                worksheet.Columns().AdjustToContents();
                worksheet.Rows().AdjustToContents();

                workbook.SaveAs("excel.xlsx");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (vector == true || scalar == true)
            {
                excel();
                Workbook workbook = new Workbook("excel.xlsx");

                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = sfd.FileName + ".pdf";
                    workbook.Save(filepath, SaveFormat.Pdf);

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label9.Text = "";
            vector = false; scalar = false;          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
