using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProductsDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlProductsDetails.SelectedItem.Text)
            {
                case "Laptop":
                    imgProduct.ImageUrl = "~/Images/Laptop.jpg";
                    break;

                case "Mobile":
                    imgProduct.ImageUrl = "~/Images/Mobile.jpg";
                    break;

                case "Tablet":
                    imgProduct.ImageUrl = "~/Images/Tablet.jpg";
                    break;

                default:
                    imgProduct.ImageUrl = "";
                    lblPrice.Text = "";
                    break;
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProductsDetails.SelectedIndex > 0)
            {
                lblPrice.Text = "Price : Rs " + ddlProductsDetails.SelectedValue;
            }
            else
            {
                lblPrice.Text = "Please select a product first";
            }
        }
    }
}