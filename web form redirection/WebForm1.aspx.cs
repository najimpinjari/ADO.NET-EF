using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Ado_webApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //int number = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //TextNumber.Text = number.ToString();
            TextNumber.Text = hdnnumber.Value;
        }   

        protected void btnincrement_Click(object sender, EventArgs e)
        {
            //number++;
            //TextNumber.Text = number.ToString();
            int num = int.Parse(hdnnumber.Value);
            num++;

            hdnnumber.Value = num.ToString();
            TextNumber.Text = num.ToString();
        }

        //protected void btngoogle_Click(object sender, EventArgs e)
        //{
        //    //Server.Transfer("http://www.google.com");
        //    Response.Redirect("http://www.google.com");

        //}

        //protected void btnwebform2_Click(object sender, EventArgs e)
        //{
        //    //Server.Transfer("WebForm2.aspx");
        //    Response.Redirect("WebForm2.aspx");

        //}
    }
}