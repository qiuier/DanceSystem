using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1025 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        //HttpPostedFile file = this.FileUpload_xls.PostedFile;
        string fileExt = string.Empty;

        if (FileUpload_xls.HasFile)
        {
            fileExt = System.IO.Path.GetExtension(FileUpload_xls.FileName);
            if (fileExt == ".rar" || fileExt == ".zip")
            {
                try
                {
                    FileUpload_xls.SaveAs(Server.MapPath("upload") + "\\" + FileUpload_xls.FileName);
                    Label1.Text = "客户端路径：" + FileUpload_xls.PostedFile.FileName + "〈br>" +
                                  "文件名：" + System.IO.Path.GetFileName(FileUpload_xls.FileName) + "〈br>" +
                                  "文件扩展名：" + System.IO.Path.GetExtension(FileUpload_xls.FileName) + "〈br>" +
                                  "文件大小：" + FileUpload_xls.PostedFile.ContentLength + " KB〈br>" +
                                  "文件MIME类型：" + FileUpload_xls.PostedFile.ContentType + "〈br>" +
                                  "保存路径：" + Server.MapPath("upload") + "\\" + FileUpload_xls.FileName;
                }
                catch (Exception ex)
                {
                    Label1.Text = "发生错误：" + ex.Message.ToString();
                }
            }
            else
            {
                Label1.Text = "只允许上传rar、zip文件！";
            }
        }
        else
        {
            Label1.Text = "没有选择要上传的文件！";
        }
    }
}