using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class signup : System.Web.UI.Page
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
    protected void btnRegi_Click(object sender, EventArgs e)
    {
        string strIn = "INSERT INTO clients VALUES(@uname,@pass,@fname,@mno)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@uname",txtuname.Text);
        cmd.Parameters.AddWithValue("@pass",txtpass.Text);
        cmd.Parameters.AddWithValue("@fname",txtfname.Text);
        cmd.Parameters.AddWithValue("@mno",txtmno.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void btnMove_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}