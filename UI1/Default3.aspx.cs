using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder sbl = new StringBuilder();
        string[] textIn = TextBox1.Text.Split(new char[] { ',', '周'},StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < textIn.Length; i++)
        {
            if (textIn[i].IndexOf('-') != -1)
            {
                string[] textIn2 = textIn[i].Split(new char[] { '-'}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = Convert.ToInt32(textIn2[0]); j <= Convert.ToInt32(textIn2[1]); j++)
                {
                    sbl.Append(j+" ");
                }
            }
            else
            {
                sbl.Append(textIn[i] + ' ');
            }
        }
        Label2.Text = sbl.ToString();

        

    }
}