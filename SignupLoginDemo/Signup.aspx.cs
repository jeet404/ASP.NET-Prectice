using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Signup : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\SignupLoginDemo\App_Data\user_data.mdf;Integrated Security=True");
            conn.Open();
        }
        catch
        {
            Response.Write(e);
        }
    }
    protected void btnIn_Click(object sender, EventArgs e)
    {
        string regi = "INSERT INTO user_info VALUES(@fname,@lname,@uname,@pass,@mobile,@dob)";
        cmd = new SqlCommand(regi,conn);
        cmd.Parameters.AddWithValue("@fname",txtFname.Text);
        cmd.Parameters.AddWithValue("@lname",txtLname.Text);
        cmd.Parameters.AddWithValue("@uname",txtUname.Text);
        cmd.Parameters.AddWithValue("@pass",txtPass.Text);
        cmd.Parameters.AddWithValue("@mobile",txtMobile.Text);
        cmd.Parameters.AddWithValue("@dob",txtDob.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Redirect("Login.aspx");
        }
    }
}