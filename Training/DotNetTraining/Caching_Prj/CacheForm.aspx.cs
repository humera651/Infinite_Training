using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching_Prj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetProductsByName(string productname)
        {
            SqlConnection con = new SqlConnection("Data Source=ICS-LT-HQ4Q9K3;user=sa;pwd=Infinite@2025; initial catalog=infinitedb;");
            SqlDataAdapter da = new SqlDataAdapter("spGetProductByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Productname";
            param1.Value = productname;

            da.SelectCommand.Parameters.Add(param1);

            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsByName(DDL.SelectedValue);

        }
    }
}