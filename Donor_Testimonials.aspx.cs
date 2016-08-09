using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class Donors : System.Web.UI.Page
{

    DataTable dtDonors;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Call_Database callDb = new Call_Database();
        dtDonors = callDb.dbDonors;

        HtmlGenericControl div, h, p, img;

        foreach (DataRow row in dtDonors.Rows)
        {
            //Response.Write(row["name"]);
            h = new HtmlGenericControl("h3");
            h.ID = "dynDivCode2";
            h.InnerHtml = row["name"].ToString();
            accordion.Controls.Add(h);

            div = new HtmlGenericControl("div");

            img = new HtmlGenericControl("img");
            img.Attributes["src"] = row["photo"].ToString();
            img.Attributes["class"] = "photos";
            div.Controls.Add(img);

            p = new HtmlGenericControl("p");
            p.InnerHtml = row["profile"].ToString();
            div.Controls.Add(p);

            accordion.Controls.Add(div);
            h.ID = null;
            break;
        }

        Call_Database ListDB = new Call_Database();
        Repeater1.DataSource = ListDB.dbDonors;
        Repeater1.DataBind();

    }

    protected void SearchClick_Click(object sender, EventArgs e)
    {
        accordion.Controls.Clear();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        int FocusId = int.Parse((item.FindControl("idLabel") as Label).Text);

        foreach (DataRow row in dtDonors.Rows)
        {
            HtmlGenericControl div, h, p, img;
            int Focus = (int)row["Id"];

            if (Focus == FocusId)
            {

                h = new HtmlGenericControl("h3");
                h.ID = FocusId.ToString();
                h.InnerHtml = row["name"].ToString();
                accordion.Controls.Add(h);

                div = new HtmlGenericControl("div");

                img = new HtmlGenericControl("img");
                img.Attributes["src"] = row["photo"].ToString();
                img.Attributes["class"] = "photos";
                div.Controls.Add(img);

                p = new HtmlGenericControl("p");
                p.InnerHtml = row["profile"].ToString();
                div.Controls.Add(p);

                accordion.Controls.Add(div);
                h.ID = null;
            }
        }
    }

    /*
    protected void ListName_Click (object sender, EventArgs e)
    {
    }
    */
}