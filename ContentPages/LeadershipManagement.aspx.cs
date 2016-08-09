using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class ContentPages_LeadershipManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["id"] != null)
        {
            strQuery = Request.QueryString["id"].ToString();
        }

        if (!IsPostBack)
        {
            Call_Database PageDB = new Call_Database();
            //Loads AdvBoard Table
            RepeaterNum1.DataSource = PageDB.AdvBoard;
            RepeaterNum1.DataBind();
            //Loads ElecBoard Table
            RepeaterNum2.DataSource = PageDB.ElecBoard;
            RepeaterNum2.DataBind();
        }
    }

    //INSERT data into Leadership Tables
    protected void SubButton_Click(object sender, EventArgs e)
    {
        Call_Database callDB = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("AdvBoard").Selected == true)
        {
            string Action = "AdvBoardINSERT";
            callDB.FormINSERT(Action, txtName.Text, txtStatus.Text, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.AdvBoard;
            RepeaterNum1.DataBind();
        }
        if (LeadershipDisplay.Items.FindByValue("ElecBoard").Selected == true)
        {
            string Action = "ElecBoardINSERT";
            callDB.FormINSERT(Action, txtName.Text, txtYear.Text, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.ElecBoard;
            RepeaterNum2.DataBind();
        }
    }

    //Pull Up Leadership Tables & Forms
    protected void GOTO_Click(object sender, EventArgs e)
    {
        if (LeadershipDisplay.Items.FindByValue("AdvBoard").Selected == true)
        {
            AdvBoardTableShow.Visible = true;
            ElecBoardTableShow.Visible = false;
            SubmitDiv.Visible = true;
            StatusShow.Visible = true;
            YearShow.Visible = false;
        }
        else if (LeadershipDisplay.Items.FindByValue("ElecBoard").Selected == true)
        {
            ElecBoardTableShow.Visible = true;
            AdvBoardTableShow.Visible = false;
            SubmitDiv.Visible = true;
            YearShow.Visible = true;
            StatusShow.Visible = false;
        }
    }

    //DELETE data from Table
    protected void DeleteLink_Click(object sender, EventArgs e)
    {
        Call_Database deleteEntry = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("AdvBoard").Selected == true)
        {
            string Action = "AdvBoardDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.AdvBoard;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ElecBoard").Selected == true)
        {
            string Action = "ElecBoardDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.ElecBoard;
            RepeaterNum2.DataBind();
        }
    }

    //Repeater Controls for Edit
    //CONTROL Buttons for Repeater
    protected void OnEdit_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements(item, true);
    }
    protected void OnCancel_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements(item, false);
    }
    private void ToggleElements(RepeaterItem item, bool isEdit)
    {
            //Toggle Buttons.
            item.FindControl("editLink").Visible = !isEdit;
            item.FindControl("updateLink").Visible = isEdit;
            item.FindControl("cancelLink").Visible = isEdit;

            //Toggle Labels.
            item.FindControl("nameLabel").Visible = !isEdit;

            //Toggle TextBoxes.
            item.FindControl("EditName").Visible = isEdit;

        if (LeadershipDisplay.Items.FindByValue("AdvBoard").Selected == true)
        {
            item.FindControl("statusLabel").Visible = !isEdit;
            item.FindControl("EditStatus").Visible = isEdit;
        }
        else if (LeadershipDisplay.Items.FindByValue("ElecBoard").Selected == true)
        {
            item.FindControl("yearLabel").Visible = !isEdit;
            item.FindControl("EditYear").Visible = isEdit;
        }
    }

    //UPDATE datafields from Repeater Table
    protected void OnUpdate_Click(object sender, EventArgs e)
    {
        Call_Database updateEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;

        if (LeadershipDisplay.Items.FindByValue("AdvBoard").Selected == true)
        {
            string Action = "AdvBoardUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditStatus = (item.FindControl("EditStatus") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, EditStatus, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.AdvBoard;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ElecBoard").Selected == true)
        {
            string Action = "ElecBoardUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditYear = (item.FindControl("EditYear") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, EditYear, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.ElecBoard;
            RepeaterNum2.DataBind();
        }
    }

}