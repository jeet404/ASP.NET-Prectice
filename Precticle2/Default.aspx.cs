using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtUsrnm.Text == "admin@gmail.com" && txtPass.Text == "admin@123")
        {
            Response.Write("<div style='position:absolute;bottom:25%;display:flex;justify-content:center;height:auto;margin-bottom:2%;color:green;'>");
            Response.Write("<h1>You're Logged Successfully</h1>");
            Response.Write("</div>");
        }
        else
        {
            Response.Write("<div style='position:absolute;bottom:25%;display:flex;justify-content:center;height:auto;margin-bottom:2%;color:red;'>");
            Response.Write("<h1>Your Username or Password is Invalid!!!</h1>");
            Response.Write("</div>");
        }
    }
}