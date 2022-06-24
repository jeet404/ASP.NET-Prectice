using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Arrays for All
    string[] country = new string[] { "India", "USA", "Nepal", "Russia", "Australia" };
    string[] state = new string[] { "Gujrat", "Punjab", "California", "Colorado", "Bagmati", "Lumbini", "Buryatia", "Dagestan", "South Wales", "Victoria" };
    string[] city = new string[] { "Ahemdabad", "Rajkot", "Amreli", "Ludhiana", "	Amritsar", "Jalandhar", "Los Angeles", "San Diego" };

    //Arrays for State 
    string[] stOfInd = new string[] { "Gujrat", "Punjab" };
    string[] stOfUsa = new string[] { "California", "Colorado" };
    string[] stOfNep = new string[] { "Bagmati", "Lumbini" };
    string[] stOfRuss = new string[] { "Buryatia", "Dagestan" };
    string[] stOfAus = new string[] { "South Wales", "Victoria" };

    //Arrays for City
    string[] ctOfGuj = new string[] { "Ahemdabad", "Rajkot", "Amreli" };
    string[] ctOfPnb = new string[] { "Ludhiana", "	Amritsar", "Jalandhar" };
    string[] ctOfCali = new string[] { "Los Angeles", "San Diego" };

    public void getCountry()
    {
        foreach(string itm in country)
        {
            ddlCo.Items.Add(itm);
        }
    }
    public void getState()
    {
        foreach(string itm in state)
        {
            ddlSt.Items.Add(itm);
        }
    }
    public void getCity()
    {
        foreach(string itm in city)
        {
            ddlCt.Items.Add(itm);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            getCountry();
            getState();
            getCity();
        }
    }
    protected void ddlCo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlSt.Items.Clear();
        if(ddlCo.SelectedValue != "0")
        {
            if(ddlCo.SelectedValue == "India")
            {
                foreach(string itm in stOfInd)
                {
                    ddlSt.Items.Add(itm);
                }
            }
            else if(ddlCo.SelectedValue == "USA")
            {
                foreach(string itm in stOfUsa)
                {
                    ddlSt.Items.Add(itm);
                }
            }
            else if(ddlCo.SelectedValue == "Nepal")
            {
                foreach(string itm in stOfNep)
                {
                    ddlSt.Items.Add(itm);
                }
            }
            else if(ddlCo.SelectedValue == "Russia")
            {
                foreach(string itm in stOfRuss)
                {
                    ddlSt.Items.Add(itm);
                }
            }
            else if(ddlCo.SelectedValue == "Australia")
            {
                foreach(string itm in stOfAus)
                {
                    ddlSt.Items.Add(itm);
                }
            }
        }
    }
    protected void ddlSt_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCt.Items.Clear();
        if(ddlSt.SelectedValue != "0")
        {
            ddlCt.Items.Clear();
            if(ddlSt.SelectedValue == "Gujrat")
            {
                foreach(string itm in ctOfGuj)
                {
                    ddlCt.Items.Add(itm);
                }
            }
            else if(ddlSt.SelectedValue == "Punjab")
            {
                foreach(string itm in ctOfPnb)
                {
                    ddlCt.Items.Add(itm);
                }
            }
            else if(ddlSt.SelectedValue == "California")
            {
                foreach(string itm in ctOfCali)
                {
                    ddlCt.Items.Add(itm);
                }
            }
        }
    }
}