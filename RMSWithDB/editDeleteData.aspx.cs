using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class editDeleteData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    string strCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\RMSWithDB\App_Data\rooms.mdf;Integrated Security=True";
    SqlDataAdapter da;
    DataSet ds;
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
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        getData();
    }

    public void getData()
    {
        string strGet = "SELECT * FROM rooms WHERE Id=" + txtRid.Text + "";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        if(ds.Tables[0].Rows.Count>0){

            txtRname.Text = ds.Tables[0].Rows[0]["r_type"].ToString();
            txtRprice.Text = ds.Tables[0].Rows[0]["r_price"].ToString();
        }
        else
        {
            Response.Write("No Data Found!");
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        string strEdit = "UPDATE rooms SET r_type=@rname,r_price=@rprice WHERE Id=" + txtRid.Text + "";
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@rname",txtRname.Text);
        cmd.Parameters.AddWithValue("@rprice",txtRprice.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Write("Data Updated!");
        }
        else
        {
            Response.Write("Data Not Updated!");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string strDel = "DELETE FROM rooms WHERE Id=" + txtRid.Text + "";
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            txtRid.Text = "";
            txtRname.Text = "";
            txtRprice.Text = "";
        }
        else{
            Response.Write("Issue in Deleting Data!");
        }
    }
}