using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class welcome : System.Web.UI.Page
{
    string strId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            string strId = Session.SessionID.ToString();
            lblUname.Text = Session["username"].ToString();
        }
    }
    protected void btnProtPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("protectedPage.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        lblSid.Text = strId;
    }
}