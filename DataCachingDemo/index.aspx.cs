using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["data"] = Cache["data"];
            Cache.Remove("data");
            getData();
        }
    }

    public void getData()
    {
        gvDatas.DataSource = (DataSet)ViewState["data"];
        gvDatas.DataBind();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}