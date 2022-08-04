using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        int cnt = 0;

        if (Application["Visit"] != null)
        {
            cnt = Convert.ToInt32(Application["Visit"].ToString());
        }

        cnt = cnt + 1;
        Application["Visit"] = cnt;

        Application.UnLock();
        lblResult.Text = "Total Visit = " + cnt.ToString(); 
        
    }
}