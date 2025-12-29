using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (args.Value.Length > 6)
                {
                    args.IsValid = true;
                }
                else
                    args.IsValid = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Data Validated..., saving now";
                lblmsg.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblmsg.Text = "Validation Failed.., not saving";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}