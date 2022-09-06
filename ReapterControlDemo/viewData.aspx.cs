using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class viewData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM userInfo ", conn);
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
}
