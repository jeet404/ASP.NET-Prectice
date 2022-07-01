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
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (!fuImg.HasFile)
        {
            lblImgName.Text = "File Not Found!";
        }
        else
        {
            string imgCont = fuImg.PostedFile.ContentType.ToString();
            string imgSize = fuImg.PostedFile.ContentLength.ToString();
            string imgName = fuImg.FileName.ToString();
            lblImgName.Text = imgCont + "<br>" + imgName + "<br>" + imgSize;
        }
    }
}