using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "Welcome "+Request.QueryString["myname"].ToString();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("entryPage.aspx");
    }
}