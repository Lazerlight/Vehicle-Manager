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
    public partial class CarViewerCreate : Form
    {
        public CarViewerCreate()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CarViewerCreate_Load(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        DateTime month = DateTime.Today;
                        
                        cmd.CommandText = "insert into vehicle values(N'"+carNumberValue.Text+"'," +
                            "N'" + typeFuelValue.Text + "'," +
                            " '" + litersPer100kmValue.Text + "'," +
                            " '" + kmPerMonthValue.Text + "'," +
                            " '" + kmStartPerMonthValue.Text + "'," +
                            " '" + kmEndPerMonthValue.Text + "'," +
                            " '" + litersFuelChargedPerMonthValue.Text + "'," +
                            " '" + litersFuelBurnedPerMonthValue.Text + "'," +
                            " N'" + vehicleCategoryValue.Text + "'," +
                            " N'" + Convert.ToString(month.Year) + "'," +
                            " N'" + Convert.ToString(month.Month) + "'," +
                            " N'"+ Convert.ToString(month.Day) +"'," +
                            " '"+fuelLeftValue.Text+ "'," +
                            " N'" + companyValue.Text + "'," +
                            " N'" + driverValue.Text + "'," +
                            " N'" + startingLitersFuelValue.Text + "'," +
                            " N'" + omwValue.Text + "'," +
                            " N'" + lukoilValue.Text + "') ";

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Успешно добавихте автомобил!");
                        carNumberValue.Clear();
                        typeFuelValue.Text = "";
                        litersPer100kmValue.Clear();
                        kmPerMonthValue.Clear();
                        kmStartPerMonthValue.Clear();
                        kmEndPerMonthValue.Clear();
                        litersFuelChargedPerMonthValue.Clear();
                        litersFuelBurnedPerMonthValue.Clear();
                        vehicleCategoryValue.Clear();
                        fuelLeftValue.Clear();
                        companyValue.Clear();
                        driverValue.Clear();
                        startingLitersFuelValue.Clear();
                        omwValue.Clear();
                        lukoilValue.Clear();


                    }
                }
            }
            else
            {
                MessageBox.Show("Моля въведете валидни данни!", "Грешка!");

                carNumberValue.Clear();
                typeFuelValue.Text = "";
                litersPer100kmValue.Clear();
                kmPerMonthValue.Clear();
                kmStartPerMonthValue.Clear();
                kmEndPerMonthValue.Clear();
                litersFuelChargedPerMonthValue.Clear();
                litersFuelBurnedPerMonthValue.Clear();
                vehicleCategoryValue.Clear();
                fuelLeftValue.Clear();
                companyValue.Clear();
                driverValue.Clear();
                startingLitersFuelValue.Clear();
                omwValue.Clear();
                lukoilValue.Clear();
            }
        }

        private bool ValidateForm()
        {
            string ID = carNumberValue.Text;
            DateTime date = DateTime.Now;
            int month = date.Month;
            int year = date.Year;
            bool output = true;
            double num = 0;
            bool Validate1 = double.TryParse(litersPer100kmValue.Text, out num);
            bool Validate2 = double.TryParse(kmPerMonthValue.Text, out num);
            bool Validate3 = double.TryParse(kmStartPerMonthValue.Text, out num);
            bool Validate4 = double.TryParse(kmEndPerMonthValue.Text, out num);
            bool Validate5 = double.TryParse(litersFuelChargedPerMonthValue.Text, out num);
            bool Validate6 = double.TryParse(litersFuelBurnedPerMonthValue.Text, out num);

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM vehicle";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string id = dr["Id"].ToString();
                        string M = dr["Month"].ToString();
                        string Y = dr["Year"].ToString();

                        if (ID == id && int.Parse(M) == month && int.Parse(Y) == year)
                        {
                            output = false;
                            MessageBox.Show("Този номер вече съществува в настоящият месец!");
                            break;
                        }
                    }
                    dr.Close();
                }
            }
            if (Validate1 == false)
            {
                output = false;
            }
            if (Validate2 == false)
            {
                output = false;
            }
            if (Validate5 == false)
            {
                output = false;
            }
            if (Validate6 == false)
            {
                output = false;
            }
            



            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kmPerMonthValue.Text = Convert.ToString(Math.Round(Math.Abs(Convert.ToDouble(kmStartPerMonthValue.Text) - Convert.ToDouble(kmEndPerMonthValue.Text)), 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидна информация!");
                if (kmEndPerMonthValue.Text is double || kmEndPerMonthValue.Text is decimal)
                {
                    kmStartPerMonthValue.Focus();
                }
                else
                {
                    kmEndPerMonthValue.Focus();
                }
                

            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double km = Convert.ToDouble(kmPerMonthValue.Text);
                double l100 = Convert.ToDouble(litersPer100kmValue.Text);
                double value = (km / 100) * l100;
                litersFuelBurnedPerMonthValue.Text = Math.Round(value, 2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидна информация!");
            }
               
            
        }

        private void kmPerMonthValue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            try
            {
                double lCharged = Convert.ToDouble(litersFuelChargedPerMonthValue.Text);
                double lBurned = Convert.ToDouble(litersFuelBurnedPerMonthValue.Text);

                fuelLeftValue.Text = Convert.ToString(Math.Round(lCharged - lBurned, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидна информация!");
            }
           
        }
        /// <summary>
        /// - ДА СЪЗДАМ СПРАВКА СПРЯМО ГОРИВАТА
        /// - ДА ПРИНТИРАМ СПРАВКА
        /// </summary>
       
        private void button4_Click(object sender, EventArgs e)
        {
            string ID = carNumberValue.Text;
            int year = 0;
            int month = 0;
            bool Dbol = false;

            using(SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM vehicle";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string id = dr["Id"].ToString();
                        string Y = dr["Year"].ToString();
                        string M = dr["Month"].ToString();
                       

                        if (ID == id && year <= int.Parse(Y) && month <= int.Parse(M))
                        {

                            year = int.Parse(Y);
                            month = int.Parse(M);
 
                        }                       

                    }
                    dr.Close();
                    SqlDataReader sr = cmd.ExecuteReader();

                    while (sr.Read())
                    {
                        string id = sr["Id"].ToString();
                        string FT = sr["FuelType"].ToString();
                        string L100 = sr["litresPer100km"].ToString();
                        string KMEM = sr["kmEndPerMonth"].ToString();
                        string VC = sr["vehicleCategory"].ToString();
                        string Y = sr["Year"].ToString();
                        string M = sr["Month"].ToString();
                        string D = sr["Day"].ToString();
                        string FL = sr["fuelLeft"].ToString();
                        string C = sr["company"].ToString();
                        string DRI = sr["driver"].ToString();

                        if (ID == id && year <= int.Parse(Y) && month <= int.Parse(M))
                        {

                            typeFuelValue.Text = FT;
                            litersPer100kmValue.Text = L100;
                            kmStartPerMonthValue.Text = KMEM;
                            vehicleCategoryValue.Text = VC;
                            startingLitersFuelValue.Text = FL;
                            companyValue.Text = C;
                            driverValue.Text = DRI;

                            Dbol = true;
                            break;

                        }
                        else
                        {
                            Dbol = false;
                        }
                    }
                    sr.Close();
                }
            }
            if (!Dbol)
            {
                MessageBox.Show("Няма информация за предишни месеци!");
            }
        }

        private void litersFuelBurnedPerMonthLabel_Click(object sender, EventArgs e)
        {

        }

        private void lukoilValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double SF = double.Parse(startingLitersFuelValue.Text);
                double OMW = double.Parse(omwValue.Text);
                double LUKOIL = double.Parse(lukoilValue.Text);
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
            catch (Exception)
            {
                double SF = 0;
                double OMW = 0;
                double LUKOIL = 0;
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
        }

        private void omwValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double SF = double.Parse(startingLitersFuelValue.Text);
                double OMW = double.Parse(omwValue.Text);
                double LUKOIL = double.Parse(lukoilValue.Text);
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
            catch (Exception)
            {
                double SF = 0;
                double OMW = 0;
                double LUKOIL = 0;
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
        }

        private void startingLitersFuelValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double SF = double.Parse(startingLitersFuelValue.Text);
                double OMW = double.Parse(omwValue.Text);
                double LUKOIL = double.Parse(lukoilValue.Text);
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
            catch (Exception)
            {
                double SF = 0;
                double OMW = 0;
                double LUKOIL = 0;
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            }
        }
    }
}

 
