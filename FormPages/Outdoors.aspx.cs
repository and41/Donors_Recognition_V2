using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class FormPages_Outdoors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }


        Call_Database OutdoorsDB = new Call_Database();
        Repeater1.DataSource = OutdoorsDB.dbOutdoors;
        Repeater1.DataBind();
    }
}