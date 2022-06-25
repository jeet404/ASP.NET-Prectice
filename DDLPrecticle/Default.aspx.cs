using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string city = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddcity_Click(object sender, EventArgs e)  
    {
        if(txtCity.Text != "")
        {
            if(ddlCity.Items.Contains(new ListItem(txtCity.Text)))
            {
                ddlCity.Items.Add(txtCity.Text);
            }
        }
        else
        {
            Response.Write("<script>alert('Enter Value in TextBox');</script>");
            txtCity.Text = "";
            txtCity.Focus();
        }
    }
    protected void btnGetCity_Click(object sender, EventArgs e)
    {
        city = ddlCity.SelectedValue;
        Response.Write("<div style='position:fixed;bottom:50%;display:flex;justify-content:center;height:auto;'>");
        Response.Write("<h3>You Selected : " + city + "</h3>");
        Response.Write("</div>");
    }
}