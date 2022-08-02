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

    }
    protected void btnDone_Click(object sender, EventArgs e)
    {
        ViewState["myval"] = txtCont.Text;
        txtCont.Text = "";
    }
    protected void btnRestore_Click(object sender, EventArgs e)
    {
        if (ViewState["myval"] != null)
        {
            txtCont.Text = ViewState["myval"].ToString();
        }
    }
}