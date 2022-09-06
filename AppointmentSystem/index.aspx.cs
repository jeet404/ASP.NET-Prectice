using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class index : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["apid"] != null)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
                string strGet = "SELECT * FROM appointment WHERE ap_id = " + Session["apid"];
                da = new SqlDataAdapter(strGet, conn);
                ds = new DataSet();
                da.Fill(ds);
                rprData.DataSource = ds;
                rprData.DataBind();
            }
            catch (SqlException se)
            {
                Response.Write(se);
            }
        }
        else
        {
            Response.Redirect("ViewAp.aspx");
        }
    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Session.Clear();
        Response.Redirect("ViewAp.aspx");
    }
}