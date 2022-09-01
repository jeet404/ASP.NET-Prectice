using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

public partial class AddData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    DataSet ds;
    string strImg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (fuDoc.PostedFile.ContentLength > 0)
        {
            strImg = Path.GetFileName(fuDoc.FileName);
            string imgPath = Server.MapPath("uploads") + "/" + strImg;
            fuDoc.SaveAs(imgPath);
        }
        string strIn = "INSERT INTO userInfo VALUES(@name,@city,@age,@doc)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@name", txtName.Text);
        cmd.Parameters.AddWithValue("@city", txtCity.Text);
        cmd.Parameters.AddWithValue("@age", txtAge.Text);
        cmd.Parameters.AddWithValue("@doc", strImg);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Write("Data Inserted");
        }
        else
        {
            Response.Write("Somthing went wrong!");
        }
    }
    protected void btnDisp_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewData.aspx");
    }
}