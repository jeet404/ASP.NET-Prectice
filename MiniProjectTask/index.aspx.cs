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
        //if (Session["email"] != null)
        //{
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
                conn = new SqlConnection(strCon);
                conn.Open();
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
}