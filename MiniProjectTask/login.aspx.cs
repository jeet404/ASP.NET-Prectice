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
        string strGet = "SELECT * FROM admins WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPass.Text + "'";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["email"] = txtEmail.Text;
            Response.Redirect("index.aspx");
        }
        else
        {
            Response.Write("Wrong Email or Password!");
        }
    }
}