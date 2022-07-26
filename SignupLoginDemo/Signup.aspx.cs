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
                getData();
            }
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
            getData();
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
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
    }
    protected void gvDatas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDatas.EditIndex = -1;
        this.getData();
    }
    protected void gvDatas_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int refId = Convert.ToInt32(gvDatas.DataKeys[e.RowIndex].Values[0]);
        TextBox fname = gvDatas.Rows[e.RowIndex].FindControl("txt_fname") as TextBox;
        TextBox lname = gvDatas.Rows[e.RowIndex].FindControl("txt_lname") as TextBox;
        TextBox username = gvDatas.Rows[e.RowIndex].FindControl("txt_uname") as TextBox;
        TextBox password = gvDatas.Rows[e.RowIndex].FindControl("txt_pass") as TextBox;
        TextBox mobile = gvDatas.Rows[e.RowIndex].FindControl("txt_mno") as TextBox;
        TextBox dob = gvDatas.Rows[e.RowIndex].FindControl("txt_dob") as TextBox;
        string strEdit = "UPDATE user_info SET u_fname=@fname,u_lname=@lname,u_username=@uname,u_password=@pass,u_mobile=@mobile,u_dob=@dob WHERE Id=@uid";
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@fname", fname.Text);
        cmd.Parameters.AddWithValue("@lname", lname.Text);
        cmd.Parameters.AddWithValue("@uname", username.Text);
        cmd.Parameters.AddWithValue("@pass", password.Text);
        cmd.Parameters.AddWithValue("@mobile", mobile.Text);
        cmd.Parameters.AddWithValue("@dob", dob.Text);
        cmd.Parameters.AddWithValue("@uid", refId);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            getData();
        }
    }
}