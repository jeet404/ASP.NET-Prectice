using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class login : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Jeet404\aspPrecticle\ExpTask\App_Data\resort.mdf;Integrated Security=True");
            conn.Open();
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string strGet = "SELECT * FROM clients WHERE username = '"+txtuname.Text+"' AND password = '"+txtpass.Text+"'";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["username"] = ds.Tables[0].Rows[0][1].ToString();
            Response.Redirect("index.aspx");
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void btnMove_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
}