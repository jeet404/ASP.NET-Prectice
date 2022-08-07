using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class regiForm : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    string gen;
    int apId;
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
        try
        {
            conn = new SqlConnection(strCon);
            conn.Open();
            if (!IsPostBack)
            {
                getExperts();
            }
        }
        catch(SqlException se)
        {
            Response.Write(se);
        }
    }

    public void getExperts()
    {
        string strExp = "SELECT * FROM experts";
        da = new SqlDataAdapter(strExp, conn);
        ds = new DataSet();
        da.Fill(ds);
        ddlChoice.DataSource = ds;
        ddlChoice.DataValueField = "e_name";
        ddlChoice.DataTextField = "e_name";
        ddlChoice.DataBind();
    }

    public void chkGen()
    {
        if (rdoM.Checked)
        {
            gen = rdoM.Text;
        }
        else if (rdoF.Checked)
        {
            gen = rdoF.Text;
        }
        else if (rdoO.Checked)
        {
            gen = rdoO.Text;
        }
    }

    public void GenId()
    {
        apId= new Random().Next(99999,500000);
        //Response.Write(apId);
    }

    public void clrForm()
    {
        txtfname.Text = "";
        txtemail.Text = "";
        txtmobile.Text = "";
        txtDob.Text = "";
        txtSlot.Text = "";
        ddlChoice.SelectedValue = "0";
        rdoM.Checked = false;
        rdoF.Checked = false;
        rdoO.Checked = false;
    }

    protected void btnRegi_Click(object sender, EventArgs e)
    {
        GenId();
        chkGen();
        string strIn = "INSERT INTO appointment VALUES(@id,@name,@email,@mobile,@gender,@dob,@expert,@slot)";
        cmd = new SqlCommand(strIn,conn);
        cmd.Parameters.AddWithValue("@id",apId);
        cmd.Parameters.AddWithValue("@name",txtfname.Text);
        cmd.Parameters.AddWithValue("@email",txtemail.Text);
        cmd.Parameters.AddWithValue("@mobile",txtmobile.Text);
        cmd.Parameters.AddWithValue("@gender",gen);
        cmd.Parameters.AddWithValue("@dob",txtDob.Text);
        cmd.Parameters.AddWithValue("@expert",ddlChoice.SelectedValue);
        cmd.Parameters.AddWithValue("@slot",txtSlot.Text);
        int res = cmd.ExecuteNonQuery();
        if(res > 0){
            lblMsg.ForeColor = System.Drawing.Color.Green;
            lblMsg.Text = "Your Appointment ID :  " + apId.ToString();
            clrForm();
        }
        else
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = "There are some Problem!";
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAp.aspx");
    }
}