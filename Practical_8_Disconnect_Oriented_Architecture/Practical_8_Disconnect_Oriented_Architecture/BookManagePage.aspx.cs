using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_8_Disconnect_Oriented_Architecture
{
    public partial class BookManagePage : System.Web.UI.Page
    {
        private DataTable bookDataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBookDetails();
            }
            else
            {
                if (Session["BookDataTable"] != null)
                {
                    bookDataTable = (DataTable)Session["BookDataTable"];
                }
            }
        }
        protected void LoadBookDetails()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                bookDataTable = new DataTable();
                adapter.Fill(bookDataTable);

                GridView1.DataSource = bookDataTable;
                GridView1.DataBind();
            }

            Session["BookDataTable"] = bookDataTable;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookDataTable == null)
            {
                LoadBookDetails();
            }
            foreach (GridViewRow row in GridView1.Rows)
            {
                int bookId = Convert.ToInt32(row.Cells[0].Text);
                string title = ((System.Web.UI.WebControls.TextBox)row.FindControl("txtTitle")).Text;
                string author = ((System.Web.UI.WebControls.TextBox)row.FindControl("txtAuthor")).Text;

                DataRow dr = bookDataTable.Select("BookId = " + bookId).FirstOrDefault();
                if (dr != null)
                {
                    dr["Title"] = title;
                    dr["Author"] = author;
                }
            }
            lblMessage.Text = "Changes updated in Gridview successfully !";
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Books SET Title = @Title, Author = @Author WHERE BookId = @BookId";
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = new SqlCommand(updateQuery, connection);

                    adapter.UpdateCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 100, "Title");
                    adapter.UpdateCommand.Parameters.Add("@Author", SqlDbType.NVarChar, 100, "Author");
                    adapter.UpdateCommand.Parameters.Add("@BookId", SqlDbType.Int, 4, "BookId");

                    adapter.Update(bookDataTable);

                    connection.Close();

                    lblMessage.Text = "Changes saved successfully!";
                }

                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}