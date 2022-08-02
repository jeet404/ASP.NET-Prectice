using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class signup : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
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
    protected void btnRegi_Click(object sender, EventArgs e)
    {
        string strIn = "INSERT INTO userinfo VALUES(@fname,@pass,@email,@mobile)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@fname",txtfname.Text);
        cmd.Parameters.AddWithValue("@pass",txtpass.Text);
        cmd.Parameters.AddWithValue("@email",txtemail.Text);
        cmd.Parameters.AddWithValue("@mobile",txtmobile.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Redirect("login.aspx");
        }
    }

    public void chk_user()
    {
        string strChk = "SELECT * FROM userinfo WHERE email = '"+txtemail.Text+"'";
        da = new SqlDataAdapter(strChk, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblMsg.Text = "Email Already in Used!";
            btnRegi.Enabled = false;
        }
        else
        {
            btnRegi.Enabled = true;
        }
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        chk_user();
    }
}