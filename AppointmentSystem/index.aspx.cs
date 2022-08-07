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
        string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
        try
        {
            conn = new SqlConnection(strCon);
            conn.Open();
            getData();
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
    }

    public void getData()
    {
        string strGet = "SELECT * FROM appointment WHERE ap_id = " + Session["apid"];
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        lblApNo.Text +=  ds.Tables[0].Rows[0][0].ToString();
        lblName.Text += ds.Tables[0].Rows[0][1].ToString();
        lblEmail.Text += ds.Tables[0].Rows[0][2].ToString();
        lblMobile.Text += ds.Tables[0].Rows[0][3].ToString();
        lblGen.Text += ds.Tables[0].Rows[0][4].ToString();
        DateTime dob = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
        lblDob.Text += dob.ToShortDateString();
        lblApType.Text += ds.Tables[0].Rows[0][6].ToString();
        DateTime slot = DateTime.Parse(ds.Tables[0].Rows[0][7].ToString());
        lblSlot.Text += slot.ToShortDateString();
    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Session.Clear();
        Response.Redirect("ViewAp.aspx");
    }
}