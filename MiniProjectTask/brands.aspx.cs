using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class brands : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] != null)
        {
        try
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            conn.Open();
            if (!IsPostBack)
            {
                bindBrand();
                bindCate();
            }
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strGet = "SELECT * FROM brands";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        string cname = ds.Tables[0].Rows[0][1].ToString();
        if (cname != txtBrandName.Text)
        {
            string strIn = "INSERT INTO brands VALUES (@name,@cname)";
            cmd = new SqlCommand(strIn, conn);
            cmd.Parameters.AddWithValue("@name", txtBrandName.Text);
            cmd.Parameters.AddWithValue("@cname", ddlCate.SelectedValue);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                bindBrand();
            }
            txtBrandName.Text = "";
            ddlCate.SelectedValue = "0";
        }
        else
        {
            lblErr.Text = "Already Exsists!";
        }
    }

    public void bindBrand()
    {
        string strGet = "SELECT * FROM brands";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        gvBrands.DataSource = ds;
        gvBrands.DataBind();
        lblErr.Text = "";
    }

    public void bindCate()
    {
        string strGet = "SELECT * FROM categories";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        ddlCate.DataSource = ds;
        ddlCate.DataTextField = "c_name";
        ddlCate.DataValueField = "c_name";
        ddlCate.DataBind();
        ddlCate.SelectedValue = "0";
    }
    protected void gvBrands_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvBrands.PageIndex = e.NewPageIndex;
        this.bindBrand();
    }
    protected void gvBrands_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvBrands.EditIndex = -1;
        this.bindBrand();
    }
    protected void gvBrands_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int bid = Convert.ToInt32(gvBrands.DataKeys[e.RowIndex].Values[0]);
        string strDel = "DELETE FROM brands WHERE b_id = " + bid;
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            this.bindBrand();
        }
    }
    protected void gvBrands_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvBrands.EditIndex = e.NewEditIndex;
        this.bindBrand();
    }
    protected void gvBrands_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int bid = Convert.ToInt32(gvBrands.DataKeys[e.RowIndex].Values[0]);
        string strEdit = "UPDATE brands SET b_name=@name WHERE b_id = " + bid;
        GridViewRow gvr = (GridViewRow)gvBrands.Rows[e.RowIndex];
        TextBox bname = (TextBox)gvr.Cells[0].Controls[0];
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@name", bname.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindBrand();
        }
    }
}