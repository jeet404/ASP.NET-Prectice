﻿using System;
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
        if (txtemail.Text == "abc@gmail.com" && txtpass.Text == "abc123")
        {
            Session["username"] = txtemail.Text;
            Response.Redirect("index.aspx");
        }
        else
        {
            lblErr.Text = "Wrong Email or Password!";
        }
    }
}