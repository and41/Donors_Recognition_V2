using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iFrame_Data_SFunds : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["Id"] != null)
        {
            strQuery = Request.QueryString["Id"].ToString();
        }




        Call_Database classDB = new Call_Database();
        Repeater1.DataSource = classDB.AdvBoard;
        Repeater1.DataBind();
    }
}