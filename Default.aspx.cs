using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    DataTable dtDonors;

    protected void Page_Load(object sender, EventArgs e)
    {

        Call_Database callDb = new Call_Database();
        dtDonors = callDb.dbDonors;

        HtmlGenericControl div, img;

        foreach (DataRow row in dtDonors.Rows)
        {
            string DenyPhoto = "Images/dbImages/";

            string Deny = (string)row["photo"];
            if (Deny != DenyPhoto)
            {
                div = new HtmlGenericControl("div");
                div.Attributes["class"] = "swiper-slide";
                SlideShowDiv.Controls.Add(div);

                img = new HtmlGenericControl("img");
                img.Attributes["src"] = row["photo"].ToString();
                div.Controls.Add(img);
            }
        }
    }
}