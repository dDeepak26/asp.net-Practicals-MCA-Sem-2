using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmer_Table_Connection_Oriented_Architecture
{
    public partial class Farmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age = Convert.ToInt32(txtAge.Text.Trim());
            string location = txtLocation.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["FarmersConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Farmers (Name, Age, Location) VALUES (@Name, @Age, @Location)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Location", location);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            ClearTextBoxes();
            BindFarmersGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int farmerID = Convert.ToInt32(txtFarmerID.Text.Trim());

            string connectionString = ConfigurationManager.ConnectionStrings["FarmersConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Farmers WHERE FarmerID = @FarmerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FarmerID", farmerID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            ClearTextBoxes();
            BindFarmersGrid();
        }

        private void BindFarmersGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FarmersConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT FarmerID, Name, Age, Location FROM Farmers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                gvFarmers.DataSource = ds;
                gvFarmers.DataBind();
            }
        }

        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtLocation.Text = "";
            txtFarmerID.Text = "";
        }
    }
}