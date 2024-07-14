using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practical_16_Consuming_Web_Services
{
    /// <summary>
    /// Summary description for calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class calculator : System.Web.Services.WebService
    {
        [WebMethod(Description = "Calculator Application and Parameters")]
        public string Calculator1(int firstvalue, int secondvalue, string operation)
        {
            float result = 0;
            switch (operation)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    break;
                case "-":
                    result = firstvalue - secondvalue;
                    break;
                case "*":
                    result = firstvalue * secondvalue;
                    break;
                case "/":
                    result = firstvalue / secondvalue;
                    break;
            }
            return result.ToString();
        }
    }
}

