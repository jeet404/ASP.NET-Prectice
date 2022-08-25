using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class products : System.Web.UI.Page
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
                bindProduct();
                bindCategory();
                bindBrand();
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
        if (ddlBrand.SelectedValue != "0" && ddlCat.SelectedValue != "0")
        {
            string strGet = "SELECT * FROM products";
            da = new SqlDataAdapter(strGet, conn);
            ds = new DataSet();
            da.Fill(ds);
            string cname = ds.Tables[0].Rows[0][1].ToString();
            if (cname != txtPname.Text)
            {
            string strIn = "INSERT INTO products VALUES (@name,@spec,@brand,@cate,@price)";
            cmd = new SqlCommand(strIn, conn);
            cmd.Parameters.AddWithValue("@name", txtPname.Text);
            cmd.Parameters.AddWithValue("@spec", txtSpec.Text);
            cmd.Parameters.AddWithValue("@brand", ddlBrand.SelectedValue);
            cmd.Parameters.AddWithValue("@cate", ddlCat.SelectedValue);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                bindProduct();
                txtPname.Text = "";
                txtPrice.Text = "";
                txtSpec.Text = "";
                ddlBrand.SelectedValue = "0";
                ddlCat.SelectedValue = "0";
            }
            }
            else
            {
                lblErr.Text = "Already Exsists!";
            }
        }
        else
        {
            lblErr.Text = "Select valid Category OR Brand!";
        }
    }

    public void bindProduct()
    {
        string strGet = "SELECT * FROM products";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        gvProducts.DataSource = ds;
        gvProducts.DataBind();
        lblErr.Text = "";
    }

    public void bindBrand()
    {
        string strGet = "SELECT * FROM brands";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        ddlBrand.DataSource = ds;
        ddlBrand.DataValueField = "b_name";
        ddlBrand.DataTextField = "b_name";
        ddlBrand.DataBind();
    }

    public void bindCategory()
    {
        string strGet = "SELECT * FROM categories";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        ddlCat.DataSource = ds;
        ddlCat.DataValueField = "c_name";
        ddlCat.DataTextField = "c_name";
        ddlCat.DataBind();
    }
    protected void gvProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProducts.PageIndex = e.NewPageIndex;
        this.bindProduct();
    }
    protected void gvProducts_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvProducts.EditIndex = -1;
        this.bindProduct();
    }
    protected void gvProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int pid = Convert.ToInt32(gvProducts.DataKeys[e.RowIndex].Values[0]);
        string strDel = "DELETE FROM products WHERE p_id = " + pid;
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            this.bindProduct();
        }
    }
    protected void gvProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvProducts.EditIndex = e.NewEditIndex;
        this.bindProduct();
    }
    protected void gvProducts_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int pid = Convert.ToInt32(gvProducts.DataKeys[e.RowIndex].Values[0]);
        string strEdit = "UPDATE products SET p_name=@name,p_spec=@spec,p_price=@price WHERE p_id = " + pid;
        GridViewRow gvr = (GridViewRow)gvProducts.Rows[e.RowIndex];
        TextBox pname = (TextBox)gvr.Cells[0].Controls[0];
        TextBox pspec = (TextBox)gvr.Cells[1].Controls[0];
        TextBox pprice = (TextBox)gvr.Cells[4].Controls[0];
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@name", pname.Text);
        cmd.Parameters.AddWithValue("@spec", pspec.Text);
        cmd.Parameters.AddWithValue("@price", pprice.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindProduct();
        }
    }
}