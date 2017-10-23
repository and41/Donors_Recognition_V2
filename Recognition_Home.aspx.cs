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

    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        string strVideo = "";
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }

        Call_Database FoundersDB = new Call_Database();
        Repeater1.DataSource = FoundersDB.dbFounders;
        Repeater1.DataBind();


        Call_Database VideoDB = new Call_Database();
        strVideo = VideoDB.VideoLOAD();

        urIframe.Attributes.Add("src", strVideo.ToString());

        Call_Database CornerstoneDB = new Call_Database();
        Repeater2.DataSource = CornerstoneDB.dbCornerstone;
        Repeater2.DataBind();

        Call_Database ScholarshipsDB = new Call_Database();
        Repeater3.DataSource = ScholarshipsDB.dbScholarships;
        Repeater3.DataBind();

        Call_Database RoundtableDB = new Call_Database();
        Repeater4.DataSource = RoundtableDB.dbRoundtable;
        Repeater4.DataBind();

        Call_Database PresidentsTabDB = new Call_Database();
        Repeater5.DataSource = PresidentsTabDB.dbPresidentsTab;
        Repeater5.DataBind();

        Call_Database QuadrangleTabDB = new Call_Database();
        Repeater6.DataSource = QuadrangleTabDB.dbQuadrangleTab;
        Repeater6.DataBind();

        Call_Database BlueGoldTabDB = new Call_Database();
        Repeater7.DataSource = BlueGoldTabDB.dbBlueGoldTab;
        Repeater7.DataBind();

        Call_Database CenturyTabDB = new Call_Database();
        Repeater8.DataSource = CenturyTabDB.dbCenturyTab;
        Repeater8.DataBind();

        Call_Database OtherDonorsTabDB = new Call_Database();
        Repeater9.DataSource = OtherDonorsTabDB.dbOtherDonorsTab;
        Repeater9.DataBind();
    }
}