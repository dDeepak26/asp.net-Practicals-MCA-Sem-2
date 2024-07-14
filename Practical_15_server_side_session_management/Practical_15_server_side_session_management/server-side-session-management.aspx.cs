using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_15_server_side_session_management
{
    public partial class server_side_session_management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the session data exists
            if (Session["SessionData"] != null)
            {
                lblMessage.Text = "Session Data: " + Session["SessionData"].ToString();
            }
        }
        protected void btnSetSession_Click(object sender, EventArgs e)
        {
            // Set session data on the server
            Session["SessionData"] = "Hello, this is session data from Deepak Durgam.";
            lblMessage.Text = "Session Data Set: " + Session["SessionData"].ToString();
        }
        protected void btnGetSession_Click(object sender, EventArgs e)
        {
            // Get session data from the server
            if (Session["SessionData"] != null)
            {
                lblMessage.Text = "Session Data: " + Session["SessionData"].ToString();
            }
            else
            {
                lblMessage.Text = "No session data found.";
            }
        }
        protected void btnClearSession_Click(object sender, EventArgs e)
        {
            // Clear session data on the server
            Session.Clear();
            lblMessage.Text = "Session Data Cleared.";
        }
    }
}