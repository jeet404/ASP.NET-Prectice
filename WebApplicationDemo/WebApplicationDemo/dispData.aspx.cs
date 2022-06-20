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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlDataAdapter Adp;
        DataTable Dt;
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
                DisplayRecord(); 
            }
            catch
            {
                lbl_stat.Text = "Not Connected";
            }
        }

        public DataTable DisplayRecord()
        {
            Adp = new SqlDataAdapter("SELECT * FROM people", conn);
            Dt = new DataTable();
            Adp.Fill(Dt);
            grid1.DataSource = Dt;
            grid1.DataBind();
            return Dt;
        } 
    }
}