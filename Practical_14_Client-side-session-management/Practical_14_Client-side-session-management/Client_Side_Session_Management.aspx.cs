using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_14_Client_side_session_management
{
    public partial class Client_Side_Session_Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the session cookie exists
            if (Request.Cookies["SessionData"] != null)
            {
                lblMessage.Text = "Session Data: " + Request.Cookies["SessionData"].Value;
            }
        }

        protected void btnSetSession_Click(object sender, EventArgs e)
        {
            // Set session data in a cookie
            HttpCookie sessionCookie = new HttpCookie("SessionData");
            sessionCookie.Value = "Hello, this is session data.";
            sessionCookie.Expires = DateTime.Now.AddMinutes(30); // Set cookie to expire in 30 minutes
            Response.Cookies.Add(sessionCookie);

            lblMessage.Text = "Session Data Set: " + sessionCookie.Value;
        }

        protected void btnGetSession_Click(object sender, EventArgs e)
        {
            // Get session data from the cookie
            if (Request.Cookies["SessionData"] != null)
            {
                lblMessage.Text = "Session Data: " + Request.Cookies["SessionData"].Value;
            }
            else
            {
                lblMessage.Text = "No session data found.";
            }
        }

        protected void btnClearSession_Click(object sender, EventArgs e)
        {
            // Clear session data by expiring the cookie
            HttpCookie sessionCookie = new HttpCookie("SessionData");
            sessionCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(sessionCookie);

            lblMessage.Text = "Session Data Cleared.";
        }
    }
}