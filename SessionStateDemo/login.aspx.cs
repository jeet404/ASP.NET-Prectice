using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtpass.Text == "developer")
        {
            Session["username"] = txtuname.Text;
            Response.Redirect("welcome.aspx");
        }
        else
        {
            lblErr.Text = "Invalid Password!";
        }
    }
}