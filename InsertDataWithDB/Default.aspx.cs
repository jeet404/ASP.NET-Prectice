using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\InsertDataWithDB\App_Data\ksc_info.mdf;Integrated Security=True");
            conn.Open();
        }
        catch(Exception)
        {
            Response.Write(e);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string strIn = "INSERT INTO person_info VALUES(@name,@mobile,@email)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@name", txtName.Text);
        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
        cmd.ExecuteNonQuery();
        txtName.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
    }
}