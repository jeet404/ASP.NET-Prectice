using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class category : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["email"] != null)
        //{
        try
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            conn.Open();
            if (!IsPostBack)
            {
                bindCat();
            }
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
        //}
        //else
        //{
        //    Response.Redirect("login.aspx");
        //}
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strGet = "SELECT * FROM categories";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        string cname = ds.Tables[0].Rows[0][1].ToString();
        if (cname != txtCateName.Text)
        {
            string strIn = "INSERT INTO categories VALUES (@name)";
            cmd = new SqlCommand(strIn, conn);
            cmd.Parameters.AddWithValue("@name", txtCateName.Text);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                bindCat();
            }
            txtCateName.Text = "";
        }
        else
        {
            lblErr.Text = "Already Exsists!";
        }
    }

    public void bindCat()
    {
        string strGet = "SELECT * FROM categories";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        gvCategory.DataSource = ds;
        gvCategory.DataBind();
        lblErr.Text = "";
    }
    protected void gvCategory_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvCategory.EditIndex = e.NewEditIndex;
        this.bindCat();
    }
    protected void gvCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int cid = Convert.ToInt32(gvCategory.DataKeys[e.RowIndex].Values[0]);
        string strDel = "DELETE FROM categories WHERE c_id = " + cid;
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            this.bindCat();
        }
    }
    protected void gvCategory_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int cid = Convert.ToInt32(gvCategory.DataKeys[e.RowIndex].Values[0]);
        string strEdit = "UPDATE categories SET c_name=@name WHERE c_id = " + cid;
        GridViewRow gvr = (GridViewRow)gvCategory.Rows[e.RowIndex];
        TextBox cname = (TextBox)gvr.Cells[0].Controls[0];
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@name", cname.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindCat();
        }
    }
    protected void gvCategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvCategory.PageIndex = e.NewPageIndex;
        this.bindCat();
    }
    protected void gvCategory_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvCategory.EditIndex = -1;
        this.bindCat();
    }
}