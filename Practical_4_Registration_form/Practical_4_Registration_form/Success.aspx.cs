using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4_Registration_form
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve username from session (assuming it was stored in session after successful registration)
                string username = Session["Username"] as string;
                if (!string.IsNullOrEmpty(username))
                {
                     lblMessage.Text = "Welcome!";
                     lblUsername.Text = "Your username is: " + username;
                }
                else
                {
                    // If username is not found in session, redirect to default page
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}