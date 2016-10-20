using System;
using System.Collections.Generic;
using System.Data;
using BLL;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSql = "select * from UserfTest where userid = "+ TextBox1.Text+"";
        DataTable dt = UserLog.UserLogIn(strSql);
        if (dt.Rows.Count == 1)
        {
            Response.Write("<script>alert('登录成功')</script>");
            Session["userid"] = TextBox1.Text;
            Session["userRole"] = dt.Rows[0][2];
            Response.Redirect("MainWeb.aspx");
        }
        else
        {
            Response.Write("<script>alert('登录失败')</script>");
        }

    }

    private void Coding()
    {
        Random ra = new Random();
        string coding = "";
        for (int i = 0; i < 4; i++)
        {
            coding += ra.Next(10);
        }
        Bitmap bt = new Bitmap(80, 20);
        Graphics git = Graphics.FromImage(bt);
        Font font = new Font("Times New Roman", 10, FontStyle.Strikeout);
        git.DrawString(coding, font, Brushes.AliceBlue, 0, 0);
        bt.Save(Response.OutputStream, ImageFormat.Gif);
    }
}