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

namespace WinFormsApp1
{
    public partial class MainForm : Form                 
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // TODO - FIX SPETEMBER DELETE BUTTON
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void carNumberSearchButton_Click(object sender, EventArgs e)
        {

            string carID = carNumberValue.Text;
            string year = yearIndexValue.Text;
            string month = monthIndexValue.Text;
            bool Dbol = false;

            if (monthIndexValue.Text == "Януари")
            {
                month = "1";
            }
            else if (monthIndexValue.Text == "Февруари")
            {
                month = "2";
            }
            else if (monthIndexValue.Text == "Март")
            {
                month = "3";
            }
            else if (monthIndexValue.Text == "Април")
            {
                month = "4";
            }
            else if (monthIndexValue.Text == "Май")
            {
                month = "5";
            }
            else if (monthIndexValue.Text == "Юни")
            {
                month = "6";
            }
            else if (monthIndexValue.Text == "Юли")
            {
                month = "7";
            }
            else if (monthIndexValue.Text == "Август")
            {
                month = "8";
            }
            else if (monthIndexValue.Text == "Септември")
            {
                month = "9";
            }
            else if (monthIndexValue.Text == "Октомври")
            {
                month = "10";
            }
            else if (monthIndexValue.Text == "Ноември")
            {
                month = "11";
            }
            else if (monthIndexValue.Text == "Декември")
            {
                month = "12";
            }
            else
            {
                month = "-";
            }
            try
            {
                if (int.Parse(year) != 0)
                {

                }
            }
            catch (Exception)
            {
                year = "-";
            }

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM vehicle";

                    SqlDataReader dr = cmd.ExecuteReader();

                    vehicleListBox.Items.Clear();

                    while (dr.Read())
                    {
                        string sqlID = dr["Id"].ToString();
                        string sqlYear = dr["Year"].ToString();
                        string sqlMonth = dr["Month"].ToString();


                        if (carID == sqlID || sqlID.Contains(carID) && year == sqlYear && month == sqlMonth)
                        {

                            string value = $"{sqlID} - {namingMonth(sqlMonth)} {sqlYear}г.";
                            vehicleListBox.Items.Add(value);
                            Dbol = true;

                        }
                        else if (carID == sqlID || sqlID.Contains(carID) && year == "-" && month == "-")
                        {
                            string value = $"{sqlID} - {namingMonth(sqlMonth)} {sqlYear}г.";
                            vehicleListBox.Items.Add(value);
                            Dbol = true;

                        }
                        else if (carID == sqlID || sqlID.Contains(carID) && year == sqlYear && month == "-")
                        {
                            string value = $"{sqlID} - {namingMonth(sqlMonth)} {sqlYear}г.";
                            vehicleListBox.Items.Add(value);
                            Dbol = true;

                        }
                        else if (carID == sqlID || sqlID.Contains(carID) && year == "-" && month == sqlMonth)
                        {
                            string value = $"{sqlID} - {namingMonth(sqlMonth)} {sqlYear}г.";
                            vehicleListBox.Items.Add(value);
                            Dbol = true;
                        }



                    }
                    dr.Close();

                }
                // TODO jj
            }
            if (Dbol == false)
            {
                MessageBox.Show("Няма намерена информация!", "Съобщение");
            }

        }

        private void createNewNumberButton_Click(object sender, EventArgs e)
        {
            CarViewerCreate newForm = new CarViewerCreate();
            newForm.Show();
        }

        private void openSelectedButton_Click(object sender, EventArgs e)
        {
            if (vehicleListBox.Items.Count == 0 || vehicleListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Моля, изберете номер от таблото!");
                MessageBox.Show("В случай, че няма такъв натиснете бутона за търсене!");
                return;
            }
            string item = vehicleListBox.SelectedItem.ToString();
            var value = item.Substring(0, item.IndexOf(' '));

            CarViewerView formNEW = new CarViewerView();
            formNEW.CarNumberValue = value;
            formNEW.Show();
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

        private void createTableButton_Click(object sender, EventArgs e)
        {
            CarViewerTable forma = new CarViewerTable();
            forma.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (vehicleListBox.SelectedItems.Count == 0 || vehicleListBox.Items.Count == 0)
            {
                MessageBox.Show("Моля изберете номер от таблото!");
                MessageBox.Show("В случай, че няма такива натиснете бутона за търсене!");
                return;
            }
            string item = vehicleListBox.SelectedItem.ToString();
            string carIDstring = item.Substring(0, item.IndexOf(' '));
            string monthSUBS = item.Substring(item.IndexOf('-') + 2);
            string monthString = monthSUBS.Substring(0, monthSUBS.IndexOf(' '));
            string yearSUBS = monthSUBS.Substring(monthSUBS.IndexOf(' '));
            string yearString = yearSUBS.Substring(1, yearSUBS.IndexOf('г') -1);

            if (monthString == "Януари")
            {
                monthString = "1";
            }
            else if (monthString == "Февруари")
            {
                monthString = "2";
            }
            else if (monthString == "Март")
            {
                monthString = "3";
            }
            else if (monthString == "Април")
            {
                monthString = "4";
            }
            else if (monthString == "Май")
            {
                monthString = "5";
            }
            else if (monthString == "Юни")
            {
                monthString = "6";
            }
            else if (monthString == "Юли")
            {
                monthString = "7";
            }
            else if (monthString == "Август")
            {
                monthString = "8";
            }
            else if (monthString == "Септември")
            {
                monthString = "9";
            }
            else if (monthString == "Октомври")
            {
                monthString = "10";
            }
            else if (monthString == "Ноември")
            {
                monthString = "11";
            }
            else if (monthString == "Декември")
            {
                monthString = "12";
            }
            else
            {
                monthString = "0";
            }

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;MultipleActiveResultSets=True;Integrated Security=True;Connect Timeout=30";
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM vehicle";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string carID = dr["Id"].ToString();
                            string month = dr["Month"].ToString();
                            string year = dr["Year"].ToString();
                            
                            if (carIDstring == carID && monthString == month & yearString == year)
                            {
                                using (SqlCommand delete = new SqlCommand())
                                {
                                    delete.Connection = con;
                                    delete.CommandText = "DELETE FROM vehicle WHERE Id= N'"+carID+ "' AND Month='" + month + "' AND Year='" + year + "'";
                                    delete.ExecuteNonQuery();
                                    vehicleListBox.Items.Remove(item);
                                    break;
                                }
                            }
                        }
                        dr.Close();
                    }
                }
            }

        }
    }

}
