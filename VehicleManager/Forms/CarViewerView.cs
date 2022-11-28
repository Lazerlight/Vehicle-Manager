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
    public partial class CarViewerView : Form
    {
        public CarViewerView()
        {
            InitializeComponent();
        }

        private void carNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarViewerView_Load(object sender, EventArgs e)
        {
            string ID = carNumberValue.Text;
            bool Dbol = false;
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
                        string FT = dr["FuelType"].ToString();
                        string L100 = dr["litresPer100km"].ToString();
                        string KMM = dr["kmPerMonth"].ToString();
                        string KMSM = dr["kmStartPerMonth"].ToString();
                        string KMEM = dr["kmEndPerMonth"].ToString();
                        string FC = dr["fuelChargedPerMonth"].ToString();
                        string FB = dr["fuelBurnedPerMonth"].ToString();
                        string VC = dr["vehicleCategory"].ToString();
                        string Y = dr["Year"].ToString();
                        string M = dr["Month"].ToString();
                        string D = dr["Day"].ToString();
                        string FL = dr["fuelLeft"].ToString();
                        string C = dr["company"].ToString();
                        string DRI = dr["driver"].ToString();
                        string SF = dr["startingFuel"].ToString();
                        string OMW = dr["OMW"].ToString();
                        string OIL = dr["LUKOIL"].ToString();

                        if (ID == id)
                        {

                            typeFuelValue.Text = FT;
                            litersPer100kmValue.Text = L100;
                            kmPerMonthValue.Text = KMM;
                            kmStartPerMonthValue.Text = KMSM;
                            kmEndPerMonthValue.Text = KMEM;
                            litersFuelChargedPerMonthValue.Text = FC;
                            litersFuelBurnedPerMonthValue.Text = FB;
                            vehicleCategoryValue.Text = VC;
                            dateValue.Text = $"{D}.{M}.{Y}г.";
                            fuelLeftValue.Text = FL;
                            companyValue.Text = C;
                            driverValue.Text = DRI;
                            startingLitersFuelValue.Text = SF;
                            omwValue.Text = OMW;
                            lukoilValue.Text = OIL;


                            Dbol = true;
                            break;

                        }
                        else
                        {
                            Dbol = false;
                        }


                    }
                    dr.Close();




                }

            }
            if (Dbol == false)
            {
                MessageBox.Show("ERROR!");
            }
        }
        public string CarNumberValue
        {
            get { return (string)carNumberValue.Text; }
            set { carNumberValue.Text = value; }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VehicleManagerApplication\SQLlocalDBforVM.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    
                    cmd.Connection = con;
                    cmd.CommandText = $"update vehicle set Id=N'"+carNumberValue.Text+ "'," +
                        " FuelType=N'" + typeFuelValue.Text + "'," +
                        " litresPer100km='" + litersPer100kmValue.Text + "'," +
                        " kmPerMonth='" + kmPerMonthValue.Text + "'," +
                        " kmStartPerMonth='" + kmStartPerMonthValue.Text + "'," +
                        " kmEndPerMonth='" + kmEndPerMonthValue.Text + "'," +
                        " fuelChargedPerMonth='" + litersFuelChargedPerMonthValue.Text + "'," +
                        " fuelBurnedPerMonth='" + litersFuelBurnedPerMonthValue.Text + "'," +
                        " vehicleCategory=N'" + vehicleCategoryValue.Text + "'," +
                        " fuelLeft=N'"+fuelLeftValue.Text+ "'," +
                        " company=N'" + companyValue.Text + "'," +
                        " driver=N'" + driverValue.Text + "'," +
                        " startingFuel=N'"+startingLitersFuelValue.Text+ "'," +
                        " OMW=N'" + omwValue.Text + "'," +
                        " LUKOIL=N'" + lukoilValue.Text + "' where Id= N'" + carNumberValue.Text+ "' ";

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успешно редактирахте автомобил!");
                    this.Close();
                }
            }
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

        private void startingLitersFuelValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double SF = double.Parse(startingLitersFuelValue.Text);
                double OMW = double.Parse(omwValue.Text);
                double LUKOIL = double.Parse(lukoilValue.Text);
                litersFuelChargedPerMonthValue.Text = Math.Round(SF + OMW + LUKOIL, 2).ToString();
            } catch (Exception)
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
    }
}

