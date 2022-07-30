using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class roomsData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    string strCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\RMSWithDB\App_Data\rooms.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        catch
        {
            Response.Write(e);
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strIn = "INSERT INTO rooms VALUES(@rname,@rprice)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@rname", txtRname.Text);
        cmd.Parameters.AddWithValue("@rprice", txtRprice.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Write("Room Added Successfully");
            txtRname.Text = "";
            txtRprice.Text = "";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("editDeleteData.aspx");
    }
}