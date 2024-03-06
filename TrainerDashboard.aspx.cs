using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Ado_webApp
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["ADODOTNET"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer",con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            gvTrainers.DataSource = reader;
            gvTrainers.DataBind();

            lblmessage.Text = "Trainers loded from database";

            con.Close();

        }
    }
}