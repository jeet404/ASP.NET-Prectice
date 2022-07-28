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
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WorkSpace\aspPrecticle\SignupLoginDemo\App_Data\user_data.mdf;Integrated Security=True");
            conn.Open();
            if (!IsPostBack)
            {
                //getData();
            }
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
            getData();
        }
        else
        {
            lblres.Text = "User not Available!";
        }
    }

    public void getData()
    {
        string strData = "SELECT * FROM user_info";
        da = new SqlDataAdapter(strData, conn);
        ds = new DataSet();
        da.Fill(ds);
        gvDatas.DataSource = ds;
        gvDatas.DataBind();
    }
    protected void gvData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDatas.PageIndex = e.NewPageIndex;
        this.getData();
    }
    protected void gvDatas_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int refId = Convert.ToInt32(gvDatas.DataKeys[e.RowIndex].Values[0]);
        string strDel = "DELETE FROM user_info WHERE Id = " + refId + "";
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            getData();
        }
    }
    protected void gvDatas_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDatas.EditIndex = e.NewEditIndex;
        this.getData();
        (gvDatas.Rows[e.NewEditIndex].Cells[0].Controls[0] as TextBox).ReadOnly = true;
    }
    protected void gvDatas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDatas.EditIndex = -1;
        this.getData();
    }
    protected void gvDatas_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int refId = Convert.ToInt32(gvDatas.DataKeys[e.RowIndex].Values[0]);
        GridViewRow grd = (GridViewRow)gvDatas.Rows[e.RowIndex];
        TextBox fname = (TextBox)grd.Cells[1].Controls[0];
        TextBox lname = (TextBox)grd.Cells[2].Controls[0];
        TextBox username = (TextBox)grd.Cells[3].Controls[0];
        TextBox password = (TextBox)grd.Cells[4].Controls[0];
        TextBox mobile = (TextBox)grd.Cells[5].Controls[0];
        TextBox dob = (TextBox)grd.Cells[6].Controls[0];
        string strEdit = "UPDATE user_info SET u_fname=@fname,u_lname=@lname,u_username=@uname,u_password=@pass,u_mobile=@mobile,u_dob=@dob WHERE Id=" + refId + "";
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@fname", fname.Text);
        cmd.Parameters.AddWithValue("@lname", lname.Text);
        cmd.Parameters.AddWithValue("@uname", username.Text);
        cmd.Parameters.AddWithValue("@pass", password.Text);
        cmd.Parameters.AddWithValue("@mobile", mobile.Text);
        cmd.Parameters.AddWithValue("@dob", dob.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            getData();
            (gvDatas.Rows[e.RowIndex].Cells[0].Controls[0] as TextBox).ReadOnly = true;
        }
    }
}