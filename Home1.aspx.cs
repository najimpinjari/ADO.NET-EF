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
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    txtaspx.Text = "ASPX Textbox";
        //    txtHtml.Value = "HTML Textbox";

        //    if (IsPostBack)
        //    {
        //        Response.Write("Post request : page_load <br/> ");
        //    }
        //    else
        //    {
        //        Response.Write("GEt request : page_load <br/> ");
        //    }


        //}

        //protected void Page_Init(object sender, EventArgs e)
        //{
        //    Response.Write("Page_Init <br/>");

        //}

        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    Response.Write("Page_PreRender <br/>");

        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1_Click <br/>");

        }
    }
}