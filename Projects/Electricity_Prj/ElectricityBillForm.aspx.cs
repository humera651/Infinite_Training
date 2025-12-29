using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electricity_Prj
{
    public partial class ElectricityBillForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ElectricityBoard electricityBoard = new ElectricityBoard();
        BillValidator billValidator = new BillValidator();
        int BillCount
        {
            get { return ViewState["BillCount"] == null ? 0 : (int)ViewState["BillCount"]; }
            set { ViewState["BillCount"] = value; }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int totalBills = Convert.ToInt32(txtCount.Text);

            ElectricityBill electricityBill = new ElectricityBill();
            electricityBill.ConsumerNumber = txtNo.Text;
            electricityBill.ConsumerName = txtName.Text;

            int units = Convert.ToInt32(txtUnits.Text);

            string msg = billValidator.ValidateUnitsConsumed(units);
            if (msg != "Valid")
            {
                lblOutput.Text = msg;
                txtUnits.Focus();
                return;
            }

            electricityBill.UnitsConsumed = units;

            electricityBoard.CalculateBill(electricityBill);
            electricityBoard.AddBill(electricityBill);

            BillCount++;

            lblOutput.Text += $"{electricityBill.ConsumerNumber} {electricityBill.ConsumerName} " +
                             $"{electricityBill.UnitsConsumed} Bill Amount : {electricityBill.BillAmount}<br/>";

            txtNo.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUnits.Text = string.Empty;

            if(BillCount == totalBills)
            {
                txtCount.Text = string.Empty;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtLast.Text);
            gvBills.DataSource = electricityBoard.Generate_N_BillDetails(n);
            gvBills.DataBind();
        }
    }
}