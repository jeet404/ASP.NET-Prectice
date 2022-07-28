﻿using System;
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
        string strIn = "INSERT INTO bookings VALUES(@name,@roomtype,@totper,@totbill)";
        cmd = new SqlCommand(strIn, conn);
        cmd.Parameters.AddWithValue("@name", txtFname.Text);
        cmd.Parameters.AddWithValue("@roomtype", ddlRooms.SelectedValue);
        cmd.Parameters.AddWithValue("@totper", txtPerson.Text);
        cmd.Parameters.AddWithValue("@totbill", lblTOT.Text);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            lblres.Text = "Room Booked Successfully";
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
}