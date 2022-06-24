using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int total = 0;
    int parcel = 40;
    int small = 0;
    int mid = 0;
    int large = 0;
    int itm1 = 0, itm2 = 0, itm3 = 0, itm4 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            item_1.Enabled = false;
            item_2.Enabled = false;
            item_3.Enabled = false;
            item_4.Enabled = false;
            qty_1.Enabled = false;
            qty_2.Enabled = false;
            qty_3.Enabled = false;
            qty_4.Enabled = false;
            chkParcel.Enabled = false;
            p1.Text = "0";
            p2.Text = "0";
            p3.Text = "0";
            p4.Text = "0";
        }
    }
    protected void btnCal_Click(object sender, EventArgs e)
    {
        itm1 = Int32.Parse(p1.Text);
        itm2 = Int32.Parse(p2.Text);
        itm3 = Int32.Parse(p3.Text);
        itm4 = Int32.Parse(p4.Text);
        total = itm1 + itm2 + itm3 + itm4;
        if (chkParcel.Checked)
        {
            amtPC.Text = parcel.ToString();
            amtPT.Text = total.ToString();
        }
        else
        {
            amtPT.Text = total.ToString();
            parcel = 0;
            amtPC.Text = "0";
        }
        amtFTOT.Text = (total + parcel).ToString();
    }
    protected void SS_CheckedChanged(object sender, EventArgs e)
    {
        if (SS.Checked)
        {
            item_1.Enabled = true;
            item_2.Enabled = true;
            item_3.Enabled = true;
            item_4.Enabled = true;
        }
        else
        {
            item_1.Enabled = false;
            item_2.Enabled = false;
            item_3.Enabled = false;
            item_4.Enabled = false;
        }
    }
    protected void MS_CheckedChanged(object sender, EventArgs e)
    {
        if (MS.Checked)
        {
            item_1.Enabled = true;
            item_2.Enabled = true;
            item_3.Enabled = true;
            item_4.Enabled = true;
        }
        else
        {
            item_1.Enabled = false;
            item_2.Enabled = false;
            item_3.Enabled = false;
            item_4.Enabled = false;
        }
    }
    protected void LS_CheckedChanged(object sender, EventArgs e)
    {
        if (LS.Checked)
        {
            item_1.Enabled = true;
            item_2.Enabled = true;
            item_3.Enabled = true;
            item_4.Enabled = true;
        }
        else
        {
            item_1.Enabled = false;
            item_2.Enabled = false;
            item_3.Enabled = false;
            item_4.Enabled = false;
        }
    }
    protected void item_1_CheckedChanged(object sender, EventArgs e)
    {
        if (item_1.Checked)
        {
            qty_1.Enabled = true;
            chkParcel.Enabled = true;
        }
        else
        {
            qty_1.Enabled = false;
            chkParcel.Enabled = false;
        }
    }
    protected void item_2_CheckedChanged(object sender, EventArgs e)
    {
        if (item_2.Checked)
        {
            qty_2.Enabled = true;
            chkParcel.Enabled = true;
        }
        else
        {
            qty_2.Enabled = false;
            chkParcel.Enabled = false;
        }
    }
    protected void item_3_CheckedChanged(object sender, EventArgs e)
    {
        if (item_3.Checked)
        {
            qty_3.Enabled = true;
            chkParcel.Enabled = true;
        }
        else
        {
            qty_3.Enabled = false;
            chkParcel.Enabled = false;
        }
    }
    protected void item_4_CheckedChanged(object sender, EventArgs e)
    {
        if (item_4.Checked)
        {
            qty_4.Enabled = true;
            chkParcel.Enabled = true;
        }
        else
        {
            qty_4.Enabled = false;
            chkParcel.Enabled = false;
        }
    }
    protected void qty_1_TextChanged(object sender, EventArgs e)
    {
        if (SS.Checked)
        {
            small = 59;
            p1.Text = (Int32.Parse(qty_1.Text) * small).ToString();
        }
        else if (MS.Checked)
        {
            mid = 132;
            p1.Text = (Int32.Parse(qty_1.Text) * mid).ToString();
        }
        else if (LS.Checked)
        {
            large = 289;
            p1.Text = (Int32.Parse(qty_1.Text) * large).ToString();
        }
    }
    protected void qty_2_TextChanged(object sender, EventArgs e)
    {
        if (SS.Checked)
        {
            small = 72;
            p2.Text = (Int32.Parse(qty_2.Text) * small).ToString();
        }
        else if (MS.Checked)
        {
            mid = 145;
            p2.Text = (Int32.Parse(qty_2.Text) * mid).ToString();
        }
        else if (LS.Checked)
        {
            large = 299;
            p2.Text = (Int32.Parse(qty_2.Text) * large).ToString();
        }
    }
    protected void qty_3_TextChanged(object sender, EventArgs e)
    {
        if (SS.Checked)
        {
            small = 89;
            p3.Text = (Int32.Parse(qty_3.Text) * small).ToString();
        }
        else if (MS.Checked)
        {
            mid = 169;
            p3.Text = (Int32.Parse(qty_3.Text) * mid).ToString();
        }
        else if (LS.Checked)
        {
            large = 339;
            p3.Text = (Int32.Parse(qty_3.Text) * large).ToString();
        }
    }
    protected void qty_4_TextChanged(object sender, EventArgs e)
    {
        if (SS.Checked)
        {
            small = 110;
            p4.Text = (Int32.Parse(qty_4.Text) * small).ToString();
        }
        else if (MS.Checked)
        {
            mid = 189;
            p4.Text = (Int32.Parse(qty_4.Text) * mid).ToString();
        }
        else if (LS.Checked)
        {
            large = 379;
            p4.Text = (Int32.Parse(qty_4.Text) * large).ToString();

        }
    }
    protected void chkParcel_CheckedChanged(object sender, EventArgs e)
    {
        if(!chkParcel.Checked)
        {
            amtPC.Text = "0";
        }
        else
        {
            amtPC.Text = parcel.ToString();
        }
    }
}