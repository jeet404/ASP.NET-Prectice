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
            if (!IsPostBack)
            {
                string str = "SELECT * FROM task_info";
                da = new SqlDataAdapter(str, conn);
                dt = new DataTable();
                dt.Select(str,conn);
                da.Fill(dt);
                ddlCate.DataSource = dt;
                ddlCate.DataTextField = "c_name";
                ddlCate.DataValueField = "Id";
                ddlCate.DataBind();
            }
                txtCname.Enabled = false;
                btnAdd.Enabled = false;
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
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("INSERT INTO task_info VALUES(@cname)",conn);
        cmd.Parameters.AddWithValue("@cname", txtCname.Text);
        int i = cmd.ExecuteNonQuery();
        if (i>0)
        {
            txtCname.Text = "";
            Response.Redirect("index.aspx");
        }
    }
    protected void ddlCate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCate.SelectedValue == "other")
        {
            txtCname.Enabled = true;
            btnAdd.Enabled = true;
        }
        else
        {
            txtCname.Enabled = false;
            btnAdd.Enabled = false;
        }
    }
}