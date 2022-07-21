using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class dispData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataTable dt;
    string strCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\LogInInsertBindWithDB\App_Data\web_db.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(strCon);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                lblConStat.Text = "Conected";
                lblConStat.ForeColor = Color.Green;
            }
            if (!IsPostBack)
            {
                string sql = "SELECT * FROM category";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                ddlCate.DataSource = dt;
                ddlCate.DataValueField = "Id";
                ddlCate.DataTextField = "c_name";
                ddlCate.DataBind();
            }
        }
        catch
        {
            lblConStat.Text = "Not Conected!";
            lblConStat.ForeColor = Color.Red;
        }
    }
    protected void ddlCate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCate.SelectedValue != "0")
        {
            string sql = "SELECT * FROM category WHERE Id = " + ddlCate.SelectedValue + "";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            txtCdesc.Text = dt.Rows[0][2].ToString();
        }
        else
        {
            txtCdesc.Text = ""; 
        }
    }
}