using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class ViewAp : System.Web.UI.Page
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
            txtDob.Enabled = false;
            btnView.Enabled = false;
        }
        catch (SqlException se)
        {
            Response.Write(se);
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        string strGet = "SELECT CONVERT(VARCHAR,ap_dob,23) FROM appointment WHERE ap_id = " + txtApId.Text;
        da = new SqlDataAdapter(strGet, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (txtDob.Text == ds.Tables[0].Rows[0][0].ToString())
        {
            Session["apid"] = txtApId.Text;
            Response.Redirect("index.aspx");
        }
        else
        {
            lblErr.Text = "There are Some Issue!";
        }
    }
    protected void txtApId_TextChanged(object sender, EventArgs e)
    {
        if (txtApId.Text != "")
        {
            string chk = "SELECT * FROM appointment WHERE ap_id = " + txtApId.Text;
            da = new SqlDataAdapter(chk, conn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtDob.Enabled = true;
                btnView.Enabled = true;
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = "You are Good to Go";
            }
            else
            {
                txtDob.Enabled = false;
                btnView.Enabled = false;
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "Your Appointment Id is Invalid!";
            }
        }
        else
        {
            lblMsg.Text = "";
        }
    }
}