using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int SRoom = 750;
    int GRoom = 1500;
    int PRoom = 2500;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlRooms.SelectedValue != "0")
        {
            if (ddlRooms.SelectedValue == "S")
            {
                lblOneP.Text = SRoom.ToString();
                lblPTOT.Text = (SRoom * Int32.Parse(txtPerson.Text)).ToString();
            }
            if (ddlRooms.SelectedValue == "G")
            {
                lblOneP.Text = GRoom.ToString();
                lblPTOT.Text = (GRoom * Int32.Parse(txtPerson.Text)).ToString();
            }
            if (ddlRooms.SelectedValue == "P")
            {
                lblOneP.Text = PRoom.ToString();
                lblPTOT.Text = (PRoom * Int32.Parse(txtPerson.Text)).ToString();
            }
        }
        else
        {
            lblOneP.Text = "0";
            lblPTOT.Text = "0";
        }
    }
    protected void txtPerson_TextChanged(object sender, EventArgs e)
    {
        lblPTOT.Text = (Int32.Parse(lblOneP.Text) * Int32.Parse(txtPerson.Text)).ToString();
    }
    protected void btnCal_Click(object sender, EventArgs e)
    {
        int tex = 18;
        lblRMT.Text = lblPTOT.Text;
        lblTOT.Text = (Int32.Parse(lblRMT.Text)+(Int32.Parse(lblRMT.Text) * tex)/100).ToString();
    }
}