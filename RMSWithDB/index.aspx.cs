using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class index : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    string strCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\aspPrecticle\RMSWithDB\App_Data\rooms.mdf;Integrated Security=True";
    int person = 2;
    int app = 0;
    int roomcost = 0;
    int totofper = 0;
    int totbill = 0;
    int nettot = 0;
    int tex = 18;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(strCon);
            conn.Open();
            if (!IsPostBack)
            {
                getRooms();
                bindGv();
            }
        }
        catch
        {
            Response.Write(e);
        }
    }

    public void getRooms()
    {
        string getroom = "SELECT * FROM rooms";
        da = new SqlDataAdapter(getroom, conn);
        ds = new DataSet();
        da.Fill(ds);
        ddlRooms.DataSource = ds;
        ddlRooms.DataValueField = "r_type";
        ddlRooms.DataTextField = "r_type";
        ddlRooms.DataBind();
    }
    protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
    {
        string getroom = "SELECT * FROM rooms WHERE r_type = '"+ddlRooms.SelectedValue+"'";
        da = new SqlDataAdapter(getroom, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (ddlRooms.SelectedValue != "0")
        {
            app = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
            totofper = app * person;
            totbill = totofper;
            nettot = totbill + ((totbill * tex) / 100);
        }
        else
        {
            app = 0;
            totofper = 0;
            totbill = totofper;
            nettot = 0;
        }
        lblOneP.Text = app.ToString();
        txtPerson.Text = person.ToString();
        lblPTOT.Text = totofper.ToString();
        lblRMT.Text = totbill.ToString();
        lblTOT.Text = nettot.ToString();
    }
    protected void txtPerson_TextChanged(object sender, EventArgs e)
    {
        string getroom = "SELECT r_price FROM rooms WHERE r_type = '" + ddlRooms.SelectedValue + "'";
        da = new SqlDataAdapter(getroom, conn);
        ds = new DataSet();
        da.Fill(ds);
        if (txtPerson.Text != 0.ToString())
        {
            app = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            person =  Convert.ToInt32(txtPerson.Text);
            totofper = app * person;
            totbill = totofper;
        }
        nettot = totbill + ((totbill * tex) / 100);
        txtPerson.Text = person.ToString();
        lblPTOT.Text = totofper.ToString();
        lblRMT.Text = totbill.ToString();
        lblTOT.Text = nettot.ToString();
    }
    protected void btnCal_Click(object sender, EventArgs e)
    {
        string fName = fuDoc.FileName.ToString();
        string path = Server.MapPath("~/uploads/"+fName);
        fuDoc.SaveAs(path);
        string strIn = "INSERT INTO bookings VALUES(@name,@roomtype,@totper,@totbill,@mobile,@doc)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@name", txtFname.Text);
        cmd.Parameters.AddWithValue("@roomtype", ddlRooms.SelectedValue);
        cmd.Parameters.AddWithValue("@totper", txtPerson.Text);
        cmd.Parameters.AddWithValue("@totbill", lblTOT.Text);
        cmd.Parameters.AddWithValue("@mobile", txtMno.Text);
        cmd.Parameters.AddWithValue("@doc", "~/uploads/"+fName);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindGv();
        }
        else
        {
            lblres.Text = "Issue in booking!";
        }
        txtFname.Text = "";
        txtMno.Text = "";
        ddlRooms.SelectedValue = "0";
        lblOneP.Text = app.ToString();
        txtPerson.Text = person.ToString();
        lblPTOT.Text = totofper.ToString();
        lblRMT.Text = totbill.ToString();
        lblTOT.Text = nettot.ToString();
    }

    public void bindGv()
    {
        string strFetch = "SELECT * FROM bookings";
        da = new SqlDataAdapter(strFetch, conn);
        ds = new DataSet();
        da.Fill(ds);
        gvBooking.DataSource = ds;
        gvBooking.DataBind();
    }
    protected void gvBooking_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int bid = Convert.ToInt32(gvBooking.DataKeys[e.RowIndex].Values[0]);
        string strDel = "DELETE FROM bookings WHERE Id="+bid+"";
        cmd = new SqlCommand(strDel, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindGv();
        }
    }
    protected void gvBooking_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvBooking.EditIndex = e.NewEditIndex;
        this.bindGv();
        GridViewRow gvr = (GridViewRow)gvBooking.Rows[e.NewEditIndex];
        TextBox tid = (TextBox)gvr.Cells[0].Controls[0];
        TextBox tDoc = (TextBox)gvr.Cells[6].Controls[0];
        tDoc.ReadOnly = true;
        tid.ReadOnly = true;
    }
    protected void gvBooking_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvBooking.EditIndex = -1;
        this.bindGv();
    }
    protected void gvBooking_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int bid = Convert.ToInt32(gvBooking.DataKeys[e.RowIndex].Values[0]);
        string strEdit = "UPDATE bookings SET b_name=@name,b_roomtype=@room,b_totalpersone=@person,b_totalbill=@amt,b_mobile=@mno,b_doc=@doc WHERE Id="+bid+"";
        GridViewRow gvr = (GridViewRow) gvBooking.Rows[e.RowIndex];
        TextBox tid = (TextBox)gvr.Cells[0].Controls[0];
        TextBox tName = (TextBox)gvr.Cells[1].Controls[0];
        TextBox tMobile = (TextBox)gvr.Cells[2].Controls[0];
        TextBox tRoom = (TextBox)gvr.Cells[3].Controls[0];
        TextBox tPerson = (TextBox)gvr.Cells[4].Controls[0];
        TextBox tAmt = (TextBox)gvr.Cells[5].Controls[0];
        totbill = Convert.ToInt32(tPerson) * Convert.ToInt32(tAmt);
        totbill = totbill + (totbill * tex / 100);
        TextBox tDoc = (TextBox)gvr.Cells[6].Controls[0];
        tDoc.ReadOnly = true;
        cmd = new SqlCommand(strEdit, conn);
        cmd.Parameters.AddWithValue("@name", tName.Text);
        cmd.Parameters.AddWithValue("@room", tRoom.Text);
        cmd.Parameters.AddWithValue("@person", tPerson.Text);
        cmd.Parameters.AddWithValue("@amt", tAmt.Text);
        cmd.Parameters.AddWithValue("@mno", tMobile.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            bindGv();
            tid.ReadOnly = true;
            tDoc.ReadOnly = true;
        }
    }
}