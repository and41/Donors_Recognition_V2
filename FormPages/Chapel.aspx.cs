using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormPages_Chapel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }

        Call_Database ChapelDB = new Call_Database();
        Repeater1.DataSource = ChapelDB.dbChapelBuilding;
        Repeater1.DataBind();

        Repeater2.DataSource = ChapelDB.dbHarmonyWall;
        Repeater2.DataBind();

        Repeater3.DataSource = ChapelDB.dbHopeWall;
        Repeater3.DataBind();

        Repeater4.DataSource = ChapelDB.dbFaithWall;
        Repeater4.DataBind();

        Repeater5.DataSource = ChapelDB.dbGraceWall;
        Repeater5.DataBind();

        Repeater6.DataSource = ChapelDB.dbPeaceWall;
        Repeater6.DataBind();

        Repeater7.DataSource = ChapelDB.dbChairsBenches;
        Repeater7.DataBind();
    }
}