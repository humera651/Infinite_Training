using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataProject
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-HQ4Q9K3");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customers", con);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}