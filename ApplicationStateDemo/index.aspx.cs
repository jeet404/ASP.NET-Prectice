using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            lblResult.Text = Application["user"].ToString();
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }
}