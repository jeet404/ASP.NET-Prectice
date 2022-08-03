using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string strGo = "SELECT * FROM userinfo WHERE email = '"+txtemail.Text+"' AND pass = '"+txtpass.Text+"'";
        da = new SqlDataAdapter(strGo,conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["email"] = txtemail.Text;
            Response.Redirect("welcome.aspx");
        }
        else
        {
            lblErr.Text = "Invalid Email or Password!!";
        }
    }
    protected void btnRegi_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
}