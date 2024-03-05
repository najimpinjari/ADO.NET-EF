using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Ado_webApp
{
    public partial class Home1 : System.Web.UI.Page
    {
        //page lavel event 
        protected void Page_Load(object sender, EventArgs e)
        {
            txtaspx.Text = "ASPX Textbox";
            txtHtml.Value = "HTML Textbox";
        }

        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}