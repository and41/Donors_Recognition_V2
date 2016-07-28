using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class FormPages_FisherHall : System.Web.UI.Page
{
    DataTable dtFisher;

    protected void Page_Load(object sender, EventArgs e)
    {

        Call_Database callFisher = new Call_Database();
        dtFisher = callFisher.dbFisherHall;

        HtmlGenericControl div, h, p;

        foreach (DataRow row in dtFisher.Rows)
        {
            //Response.Write(row["name"]);
            h = new HtmlGenericControl("h3");
            h.ID = "dynDivCode2";
            h.InnerHtml = row["RoomName"].ToString();
            accordion.Controls.Add(h);

            div = new HtmlGenericControl("div");

            p = new HtmlGenericControl("p");
            p.InnerHtml = "<b>Room Plaque</b>";
            div.Controls.Add(p);

            p = new HtmlGenericControl("p");
            p.InnerHtml = row["RoomPlaque"].ToString();
            div.Controls.Add(p);

            p = new HtmlGenericControl("p");
            p.InnerHtml = "</br>";
            div.Controls.Add(p);

            p = new HtmlGenericControl("p");
            p.InnerHtml = row["Date"].ToString();

            if (p.InnerHtml != "")
            {
                p = new HtmlGenericControl("p");
                p.InnerHtml = "<b>Date</b>";
                div.Controls.Add(p);

                p = new HtmlGenericControl("p");
                p.InnerHtml = row["Date"].ToString();
                div.Controls.Add(p);
            }

            accordion.Controls.Add(div);
            h.ID = null;
        }

        Call_Database SearchFisherDB = new Call_Database();
        Repeater1.DataSource = SearchFisherDB.dbFisherHall;
        Repeater1.DataBind();

    }

    protected void SearchClick_Click(object sender, EventArgs e)
    {
        accordion.Controls.Clear();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        int FocusId = int.Parse((item.FindControl("idLabel") as Label).Text);

        foreach (DataRow row in dtFisher.Rows)
        {
            HtmlGenericControl div, h, p;
            int Focus = (int)row["Id"];

            if (Focus == FocusId)
            {

                h = new HtmlGenericControl("h3");
                h.ID = FocusId.ToString();
                h.InnerHtml = row["RoomName"].ToString();
                accordion.Controls.Add(h);

                div = new HtmlGenericControl("div");

                p = new HtmlGenericControl("p");
                p.InnerHtml = "<b>Room Plaque</b>";
                div.Controls.Add(p);

                p = new HtmlGenericControl("p");
                p.InnerHtml = row["RoomPlaque"].ToString();
                div.Controls.Add(p);

                p = new HtmlGenericControl("p");
                p.InnerHtml = "</br>";
                div.Controls.Add(p);

                p = new HtmlGenericControl("p");
                p.InnerHtml = row["Date"].ToString();

                if (p.InnerHtml != "")
                {
                    p = new HtmlGenericControl("p");
                    p.InnerHtml = "<b>Date</b>";
                    div.Controls.Add(p);

                    p = new HtmlGenericControl("p");
                    p.InnerHtml = row["Date"].ToString();
                    div.Controls.Add(p);
                }

                accordion.Controls.Add(div);
                h.ID = null;
            }
        }
    }
}