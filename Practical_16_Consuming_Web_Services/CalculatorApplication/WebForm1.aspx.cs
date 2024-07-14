using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
           ServiceReference1.calculatorSoapClient client = new ServiceReference1.calculatorSoapClient();
            string result = client.Calculator1(
            Convert.ToInt32(txtFirstValue.Text),
            Convert.ToInt32(txtSecondValue.Text),
            txtOperation.Text
            );
            if (result != "")
            {
                lblResult.Text = "Result: <b style='color:green'>" + result.ToString() + "</b>";
            }
        }
    }
}