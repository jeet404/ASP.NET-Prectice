using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtName.Text != null)
        {
            Response.Redirect("welcome.aspx?myname="+txtName.Text.ToString());
        }
        else
        {
            lblMsg.Text = "Enter Name in TextBox";
        }
    }
}