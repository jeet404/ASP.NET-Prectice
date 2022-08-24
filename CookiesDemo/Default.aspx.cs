using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSet_Click(object sender, EventArgs e)
    {
        HttpCookie userinfo = new HttpCookie("userinfo");
        if (txtName.Text != null && txtAge.Text != null)
        {
            userinfo["name"] = txtName.Text;
            userinfo["age"] = txtAge.Text;
            Response.Cookies.Add(userinfo);
            txtName.Text = "";
            txtAge.Text = "";
        }
        userinfo.Expires = DateTime.Now.AddSeconds(5);
    }
}