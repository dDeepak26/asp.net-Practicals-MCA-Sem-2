using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using display_Student_Details.ServiceReference3;

namespace display_Student_Details
{
    public partial class display_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetStudentData_Click(object sender, EventArgs e)
        {
           StudentServiceClient serviceClient = new StudentServiceClient();
            int studentID = serviceClient.getStudentId(06);
            string studentName = serviceClient.getStudentName("Deepak");
            lblResultId.Text = studentID.ToString();
            lblResultName.Text = studentName;
        }
    }
}