using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class Leadership : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }

        
        Call_Database classDBRep1 = new Call_Database();
        Repeater1.DataSource = classDBRep1.AdvBoard;
        Repeater1.DataBind();
        

        Call_Database classDBRep2 = new Call_Database();
        Repeater2.DataSource = classDBRep2.ElecBoard;
        Repeater2.DataBind();
    }
}