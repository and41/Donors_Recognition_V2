using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class Gallery : System.Web.UI.Page
{

    DataTable dtDonors;

    protected void Page_Load(object sender, EventArgs e)
    {

        Call_Database callDb = new Call_Database();
        dtDonors = callDb.dbDonors;

        HtmlGenericControl div, cap, img1, img2, bold;

        foreach (DataRow row in dtDonors.Rows)
        {
            string DenyPhoto = "Images/dbImages/";

            string Deny = (string)row["photo"];
            string Content = (string)row["profile"];
            if (Deny != DenyPhoto)
            {

                div = new HtmlGenericControl("div");
                div.Attributes["data-p"] = "112.50";
                div.Attributes["style"] = "display: none;";
                SlideShowDiv.Controls.Add(div);

                img1 = new HtmlGenericControl("img");
                img1.Attributes["data-u"] = "image";
                img1.Attributes["src"] = row["photo"].ToString();
                div.Controls.Add(img1);

                cap = new HtmlGenericControl("span");
                cap.Attributes["style"] = "position: inherit; top: 500px; left: 450px; width: 350px; height: 80px; display: block; font - size: 20px; line - height: 30px; text - align: center; background: rgba(255,255,255, 0.8); border-radius: 10px; padding: 20px; ";
                img1.Controls.Add(cap);

                bold = new HtmlGenericControl("b");
                bold.InnerHtml = row["profile"].ToString();
                cap.Controls.Add(bold);

                img2 = new HtmlGenericControl("img");
                img2.Attributes["data-u"] = "thumb";
                img2.Attributes["src"] = row["photo"].ToString();
                div.Controls.Add(img2);
            }
        }
    }
}