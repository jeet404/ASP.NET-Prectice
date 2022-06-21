using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string gen = "";
    string hb = "";
    int cnt = 0;
    CheckBox[] itm = new CheckBox[5];
    public void chk_gen()
    {
        if(rdoM.Checked == true)
        {
            gen = "Male";
        }
        else if(rdoF.Checked == true)
        {
            gen = "Female";
        }
    }
    public void chk_hb()
    {
        itm[0] = chk1;
        itm[1] = chk2;
        itm[2] = chk3;
        itm[3] = chk4;
        itm[4] = chk5;
        /*foreach(CheckBox ck in itm)
        {
            if(ck.Checked)
            {
                cnt++;
            }
        }
        if(cnt == 3)
        {
            foreach(CheckBox ck in itm)
            {
                if(ck.Checked == false)
                {
                    ck.Enabled = false;
                }
            }
        }
        else
        {
            foreach(CheckBox ck in itm)
            {
                if(ck.Checked == false)
                {
                    ck.Enabled = true;
                }
            }
        }*/
        foreach(CheckBox ck in itm)
        {
            if(ck.Checked)
            {
                hb += ck.Text + ",";
            }
        }
        hb = hb.TrimEnd(',');
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnDisp_Click(object sender, EventArgs e)
    {
        chk_gen();
        chk_hb();
        Response.Write("<div style='position:absolute;bottom:0%;display:flex;justify-content:center;height:auto;margin-bottom:2%;'>");
        Response.Write("<table border='2' style='font-size:1.4em;'>");
        Response.Write("<tr>");
        Response.Write("<th>First Name</th>");
        Response.Write("<th>Last Name</th>");
        Response.Write("<th>Age</th>");
        Response.Write("<th>DOB</th>");
        Response.Write("<th>Address</th>");
        Response.Write("<th>Email</th>");
        Response.Write("<th>Gender</th>");
        Response.Write("<th>Hobbies</th>");
        Response.Write("</tr>");
        Response.Write("<tr>");
        Response.Write("<td>" + txtFname.Text + "</td>");
        Response.Write("<td>" + txtLname.Text + "</td>");
        Response.Write("<td>" + txtAge.Text + "</td>");
        Response.Write("<td>" + txtDob.Text + "</td>");
        Response.Write("<td>" + txtAdd.Text + "</td>");
        Response.Write("<td>" + txtEmail.Text + "</td>");
        Response.Write("<td>" + gen + "</td>");
        Response.Write("<td>" + hb + "</td>");
        Response.Write("</tr>");
        Response.Write("</table>");
        Response.Write("</div>");
    }
}