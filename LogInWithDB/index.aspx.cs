using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class index : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\LogInWithDB\App_Data\web_db.mdf;Integrated Security=True");
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
        string sql = "INSERT INTO category(c_name,c_desc) VALUES('" + txtCname.Text + "','" + txtCdesc.Text + "')";
        cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Category Added Successfully')</script>");
    }
}