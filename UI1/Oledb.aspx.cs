using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Oledb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadExcel();
    }
    private void LoadExcel()
    {
        string strConn = "provider = microsoft.jett.oledb.4.0;date source='/111.xls';Extended Properties=Excel 8.0";
        OleDbConnection conn = new OleDbConnection(strConn);
        conn.Open();
        string strSql = "select * from [sheet1$]";
        OleDbDataAdapter da = new OleDbDataAdapter(strSql,conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}