using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
            string strGet = "SELECT * FROM cache_data";
            da = new SqlDataAdapter(strGet, con);
            ds = new DataSet();
            da.Fill(ds);
            ViewState["data"] = ds;
            con.Close();
        }
    }
    protected void btnMove_Click(object sender, EventArgs e)
    {
        Cache["data"] = ViewState["data"];
        Response.Redirect("index.aspx");
    }
}