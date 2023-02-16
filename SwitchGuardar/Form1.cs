using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using objExcel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.ConstrainedExecution;
using File = System.IO.File;

namespace SwitchGuardar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void Form1_Load(object sender, EventArgs e)
        {

            dvgdatos.Rows.Add("Leandro", "Lacayo", "83710688");
            dvgdatos.Rows.Add("Adriana", "Lopez", "83842742");
            dvgdatos.Rows.Add("Hollman", "Lacayo", "87759205");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int indice = cbotipoformato.SelectedIndex;


            switch (indice)
            {

                case 0:
                    objExcel.Application objAplicacion = new objExcel.Application();
                    Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

                    objAplicacion.Visible = false;



                    foreach (DataGridViewColumn columna in dvgdatos.Columns)
                    {
                        objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                        foreach (DataGridViewRow fila in dvgdatos.Rows)
                        {
                            objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                        }
                    }

                    objLibro.SaveAs(ruta + "\\Prueba.xlsx");
                    objLibro.Close();
                    MessageBox.Show("Se creo el archivo excel correctamente");

                    break;


                case 1:

                    PdfPTable pdfTable = new PdfPTable(dvgdatos.ColumnCount);

                    pdfTable.DefaultCell.Padding = 3;

                    pdfTable.WidthPercentage = 70;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    foreach (DataGridViewColumn column in dvgdatos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }
                    foreach (DataGridViewRow row in dvgdatos.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null)
                            {

                            }
                            else
                            {
                                pdfTable.AddCell(cell.Value.ToString());

                            }


                        }
                    }

                    string folderPath = "C:\\Users\\CCBB\\desktop\\Archivo PDF\\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + "Archivo.pdf", FileMode.Create))
                    {




                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);

                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Se creo el archivo pdf correctamente");
                    }
                    break;



                case 2:
                    
                    
                        StreamWriter escribir = new StreamWriter("C:\\Users\\CCBB\\desktop\\ArchivoGod.txt", true);

                        foreach (DataGridViewRow row in dvgdatos.Rows)
                        {
                            escribir.WriteLine($"{row.Cells[0].Value}--{row.Cells[1].Value}--{row.Cells[2].Value}");
                        }
                        MessageBox.Show("Se creo el archivo txt");
                        escribir.Close();
                        break;
                   
            }
        }
    }
}

