using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WorkSpace\aspPrecticle\SignupLoginDemo\App_Data\user_data.mdf;Integrated Security=True");
            conn.Open();
        }
        catch
        {
            Response.Write(e);
        }
    }
    protected void btnIn_Click(object sender, EventArgs e)
    {
        string chk = "SELECT * FROM user_info WHERE u_username='" + txtUname.Text + "' AND u_password='" + txtPass.Text + "'";
        da = new SqlDataAdapter(chk,conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblres.Text = "User is Available";
        }
        else
        {
            lblres.Text = "User not Available!";
        }
    }
}