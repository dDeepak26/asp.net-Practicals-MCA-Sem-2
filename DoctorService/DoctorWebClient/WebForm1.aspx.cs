using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DoctorWebClient.ServiceReference1;

namespace DoctorWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDoctorDetails();
            }
        }
        private void LoadDoctorDetails()
        {
            //DoctorServiceClient client = new DoctorServiceClient();
            ServiceReference1.Service2Client client = new ServiceReference1.Service2Client();
            GridView1.DataSource = client.GetDoctorDetails();
            GridView1.DataBind();
        }
    }
}