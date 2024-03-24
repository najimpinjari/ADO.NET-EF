using EF_CF1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF_CF1
{
    public partial class TrinerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDbContext db = new StudentDbContext();
            gvtrainers.DataSource = db.trainers.ToList();
            gvtrainers.DataBind();  
        }
    }
}