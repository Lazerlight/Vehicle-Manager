using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using DGVPrinterHelper;

namespace WinFormsApp1
{

    
    public partial class CarViewerTable : Form
    {
        string connetionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
        public CarViewerTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carID = carNumberValue.Text;
            string yearIndex = yearIndexValue.Text;
            string monthIndex = monthIndexValue.Text;
            string fuelIndex = fuelIndexValue.Text;
            bool Dbol = false;

            // Month Validation
            if (monthIndexValue.Text == "Януари")
            {
                monthIndex = "1";
            }
            else if (monthIndexValue.Text == "Февруари")
            {
                monthIndex = "2";
            }
            else if (monthIndexValue.Text == "Март")
            {
                monthIndex = "3";
            }
            else if (monthIndexValue.Text == "Април")
            {
                monthIndex = "4";
            }
            else if (monthIndexValue.Text == "Май")
            {
                monthIndex = "5";
            }
            else if (monthIndexValue.Text == "Юни")
            {
                monthIndex = "6";
            }
            else if (monthIndexValue.Text == "Юли")
            {
                monthIndex = "7";
            }
            else if (monthIndexValue.Text == "Август")
            {
                monthIndex = "8";
            }
            else if (monthIndexValue.Text == "Септември")
            {
                monthIndex = "9";
            }
            else if (monthIndexValue.Text == "Октомври")
            {
                monthIndex = "10";
            }
            else if (monthIndexValue.Text == "Ноември")
            {
                monthIndex = "11";
            }
            else if (monthIndexValue.Text == "Декември")
            {
                monthIndex = "12";
            }
            else
            {
                monthIndex = "-";
            }
            // Year Validation
            try
            {
                if (int.Parse(yearIndex) != 0)
                {

                }
            }
            catch (Exception)
            {
                yearIndex = "-";
            }
            // Fuel Validation
            
            if (fuelIndexValue.Text.Contains("Бензин"))
            {
                fuelIndex = "Бензин";
            }
            else if (fuelIndexValue.Text.Contains("MMDizel"))
            {
                fuelIndex = "MMDizel";
            }
            else if (fuelIndexValue.Text.Contains("ECTO") && fuelIndexValue.Text.Contains("Dizel"))
            {
                fuelIndex = "ECTO Dizel";
            }
            else if (fuelIndexValue.Text.Contains("ECTO") && fuelIndexValue.Text.Contains("100"))
            {
                fuelIndex = "ECTO100";
            }
            else if (fuelIndexValue.Text.Contains("MM100"))
            {
                fuelIndex = "MM100";
            }
            else if (fuelIndexValue.Text.Contains("Газ") || fuelIndexValue.Text.Contains("Пропан"))
            {
                fuelIndex = "Газ";
            }
            else if (fuelIndexValue.Text.Contains("Супер") || fuelIndexValue.Text.Contains("Дизел"))
            {
                fuelIndex = "Дизел";
            }
            else
            {
                fuelIndex = "-";
            }


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connetionstring;
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vehicle", con))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dataTable.Columns.Add("Година"); 
                    dataTable.Columns.Add("Месец"); 
                    dataTable.Columns.Add("Регистрационен №"); 
                    dataTable.Columns.Add("Вид - Гориво"); 
                    dataTable.Columns.Add("Разход гориво /л/ на 100км"); 
                    dataTable.Columns.Add("Пробег /км/ за месеца"); 
                    dataTable.Columns.Add("Нал. гориво в началото на месеца"); 
                    dataTable.Columns.Add("Заредено гориво (ОМВ)"); 
                    dataTable.Columns.Add("Заредено гориво (Лук Ойл)"); 
                    dataTable.Columns.Add("Общо заредено гориво за месеца"); 
                    dataTable.Columns.Add("Изразходено гориво /л/ за месеца"); 
                    dataTable.Columns.Add("Остатък гориво"); 
                    dataTable.Columns.Add("Модификация:"); 
                    dataTable.Columns.Add("Обект"); 
                    dataTable.Columns.Add("Име"); 
                    
                    while (dr.Read())
                    {
                        string id = dr["Id"].ToString();
                        string year = dr["Year"].ToString();
                        string month = dr["Month"].ToString();
                        string fuel = dr["FuelType"].ToString();
                        if (carID == id || id.Contains(carID) && yearIndex == year && monthIndex == month && fuel.Contains(fuelIndex))
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // TTT
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == "-" && monthIndex == month && fuel.Contains(fuelIndex))
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            //FTT
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == year && monthIndex == "-" && fuel.Contains(fuelIndex))
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // TFT
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == year && monthIndex == month && fuelIndex == "-")
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // TTF
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == "-" && monthIndex == "-" && fuel.Contains(fuelIndex))
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // FFT
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == "-" && monthIndex == month && fuelIndex == "-")
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // FTF
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == year && monthIndex == "-" && fuelIndex == "-")
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // TFF
                        }
                        else if (carID == id || id.Contains(carID) && yearIndex == "-" && monthIndex == "-" && fuelIndex == "-")
                        {
                            dataTable.Rows.Add(dr["Year"], namingMonth(dr["Month"].ToString()), dr["Id"], dr["FuelType"], dr["litresPer100km"], dr["kmPerMonth"], dr["startingFuel"], dr["OMW"], dr["LUKOIL"], dr["fuelChargedPerMonth"], dr["fuelBurnedPerMonth"], dr["fuelLeft"], dr["vehicleCategory"], dr["company"], dr["driver"]);
                            Dbol = true;
                            // FFF
                        }


                    }
                    dr.Close();
                    
                    dataGridView1.DataSource = dataTable;

                }
            }
            if (Dbol == false)
            {
                MessageBox.Show("Няма намерена информация!", "Съобщение");
            }
        }
        private string namingMonth(string i)
        {
            if (i == "1")
            {
                return "Януари";
            }
            else if (i == "2")
            {
                return "Февруари";
            }
            else if (i == "3")
            {
                return "Март";
            }
            else if (i == "4")
            {
                return "Април";
            }
            else if (i == "5")
            {
                return "Май";
            }
            else if (i == "6")
            {
                return "Юни";
            }
            else if (i == "7")
            {
                return "Юли";
            }
            else if (i == "8")
            {
                return "Август";
            }
            else if (i == "9")
            {
                return "Септември";
            }
            else if (i == "10")
            {
                return "Октомври";
            }
            else if (i == "11")
            {
                return "Ноември";
            }
            else if (i == "12")
            {
                return "Декември";
            }
            else
            {
                return "???";
            }
        }

        private void carNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarViewerTable_Load(object sender, EventArgs e)
        {

            
            DateTime date = DateTime.Now;

            dateValue.Text = $"{date.Day}.{date.Month}.{date.Year}г.";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Спрaвка";
            printer.SubTitle = string.Format("Дата: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.ColumnWidths.Add("Година", 40);
            printer.ColumnWidths.Add("Месец", 40);
            printer.ColumnWidths.Add("Регистрационен №", 40);
            printer.ColumnWidths.Add("Вид - Гориво", 40);
            printer.ColumnWidths.Add("Разход гориво /л/ на 100км", 80);
            printer.ColumnWidths.Add("Пробег /км/ за месеца", 80);
            printer.ColumnWidths.Add("Нал. гориво в началото на месеца", 80);
            printer.ColumnWidths.Add("Заредено гориво (ОМВ)", 80);
            printer.ColumnWidths.Add("Заредено гориво (Лук Ойл)", 80);
            printer.ColumnWidths.Add("Общо заредено гориво за месеца", 80);
            printer.ColumnWidths.Add("Изразходено гориво /л/ за месеца", 80);
            printer.ColumnWidths.Add("Остатък гориво", 80);
            printer.ColumnWidths.Add("Модификация:", 80);
            printer.ColumnWidths.Add("Обект", 80);
            printer.ColumnWidths.Add("Име", 80);
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "ОРС - Инфраструктура ООД";
            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(dataGridView1);
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap ObjBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(ObjBitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(ObjBitmap, 0, 0);
        }

        private void printButtonExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "СправкаОРС.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Не беше възможно за информацията да бъде запазена в диска!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += Convert.ToString(dataGridView1.Rows[i - 1].Cells[j].Value) + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Успешно запазихте файла!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Грешка в кода:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Моля създайте справка!");
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }
    }
}
