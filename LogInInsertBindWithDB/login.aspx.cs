using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\LogInInsertBindWithDB\App_Data\web_db.mdf;Integrated Security=True");
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                lblConStat.Text = "Conected";
                lblConStat.ForeColor = Color.Green;
            }
        }
        catch
        {
            lblConStat.Text = "Not Conected!";
            lblConStat.ForeColor = Color.Red;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM admin_login WHERE username = '"+txtUsrnm.Text+"'AND password = '"+txtPass.Text+"'";
        da = new SqlDataAdapter(sql, conn);
        dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            Response.Redirect("index.aspx");
        }
        else
        {
            Response.Write("<script>alert('Invalid Username or Password!')</script>");
        }
    }
}