using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class welcome : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
                conn = new SqlConnection(strCon);
                conn.Open();
                getData();
            }
            catch (SqlException se)
            {
                Response.Write(se);
            }
        }
    }
    protected void btnProtPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("protectedPage.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }

    public void getData()
    {
        string strEmail = Session["email"].ToString();
        string strGet = "SELECT * FROM userinfo WHERE email = '" + strEmail + "'";
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        string name = ds.Tables[0].Rows[0][1].ToString();
        string email = ds.Tables[0].Rows[0][3].ToString();
        string pass = ds.Tables[0].Rows[0][2].ToString();
        string mobile = ds.Tables[0].Rows[0][4].ToString();
        lblProfile.Text = "<div style='border: 1px solid black ; width: 300px; padding: 14px;height: auto;'> <h3>Profile : </h3><hr><h4>Full Name : "+name+"</h4><h4>Email : "+email+"</h4><h4>Password : "+pass+"</h4><h4>Mobile No : "+mobile+"</h4></div>";
    }
}