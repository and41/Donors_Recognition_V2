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
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }


        Call_Database SpecialDonorDB = new Call_Database();
        Repeater1.DataSource = SpecialDonorDB.dbFounders;
        Repeater1.DataBind();

        Call_Database HonorRollDB = new Call_Database();
        Repeater2.DataSource = HonorRollDB.dbHonorRoll;
        Repeater2.DataBind();

        Call_Database ScholarshipsDB = new Call_Database();
        Repeater3.DataSource = ScholarshipsDB.dbScholarships;
        Repeater3.DataBind();
    }
}