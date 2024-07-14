using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_10_Simple_Store_Procedure
{
    public partial class Simple_Store_Procedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@Product_ID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Product_Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@City", txtCity.Text);

                        con.Open();
                        cmd.ExecuteNonQuery(); // Execute the insert operation
                    }
                }

                txtProductID.Text = "";
                txtProductName.Text = "";
                txtCity.Text = "";

                lblMessage.Text = "Product inserted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                BindData();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BindData()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * From Product", con))
                    {
                        con.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        gridResults.DataSource = ds;
                        gridResults.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}