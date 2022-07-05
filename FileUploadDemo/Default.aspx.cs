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
            int imgSize = fuImg.PostedFile.ContentLength;
            string imgName = fuImg.FileName.ToString();
            if (imgCont == "image/jpeg")
            {
                if (imgSize <= 500000)
                {
                    lblImgName.Text = imgCont + "<br>" + imgName + "<br>" + imgSize.ToString();
                    string filePath = Server.MapPath("~/uploads/" + imgName);
                    fuImg.SaveAs(filePath);
                    imgSec.ImageUrl = "~/uploads/" + imgName;
                }
                else
                {
                    lblImgName.Text = "Minimum Size should be 500KB";
                }
            }
            else
            {
                lblImgName.Text = "Only JPEG Allowed!";
            }
        }
    }
}