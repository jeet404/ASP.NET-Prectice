using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationDemo
{
    public partial class home : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\aspdemo\WebApplicationDemo\WebApplicationDemo\App_Data\testdb.mdf;Integrated Security=True");
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    lbl_stat.Text = "Connected";
                }
            }
            catch
            {
                lbl_stat.Text = "Not Connected";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO people VALUES ('"+TextFname.Text+"','"+TextEmail.Text+"','"+TextMobile.Text+"','"+TextPass.Text+"')",conn);
            cmd.ExecuteNonQuery();
            lbl_opr.Text = "Data inserted Successfully";
            TextFname.Text = "";
            TextEmail.Text = "";
            TextMobile.Text = "";
            TextPass.Text = "";
        }
    }
}