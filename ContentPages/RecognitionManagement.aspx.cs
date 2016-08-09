using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class ContentPages_RecognitionManagement : System.Web.UI.Page
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
            //Loads Scholarships Table
            RepeaterNum1.DataSource = PageDB.dbScholarships;
            RepeaterNum1.DataBind();
            //Loads Founders Table
            RepeaterNum2.DataSource = PageDB.dbFounders;
            RepeaterNum2.DataBind();
            //Loads Society Tables
            RepeaterNum3.DataSource = PageDB.dbCornerstone;
            RepeaterNum3.DataBind();
        }
    }
    //INSERT Data into RECOGNITION TABLES
    protected void SubButton_Click(object sender, EventArgs e)
    {
        Call_Database callDB = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("Scholarships").Selected == true)
        {
            string Action = "ScholarshipsINSERT";
            callDB.FormINSERT(Action, txtSort.Text, txtName.Text, txtEstablished.Text, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbScholarships;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("Founders").Selected == true)
        {
            string Action = "FoundersINSERT";
            callDB.FormINSERT(Action, txtName.Text, txtStatus.Text, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbFounders;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CornerstoneTab").Selected == true)
        {
            string Action = "CornerstoneTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCornerstone;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("RoundtableTab").Selected == true)
        {
            string Action = "RoundtableTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbRoundtable;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("PresidentsTab").Selected == true)
        {
            string Action = "PresidentsTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbPresidentsTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("QuadrangleTab").Selected == true)
        {
            string Action = "QuadrangleTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbQuadrangleTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlueGoldTab").Selected == true)
        {
            string Action = "BlueGoldTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlueGoldTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CenturyTab").Selected == true)
        {
            string Action = "CenturyTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCenturyTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("OtherDonorsTab").Selected == true)
        {
            string Action = "OtherDonorsTabINSERT";
            callDB.FormINSERT(Action, txtName.Text, null, null, null, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbOtherDonorsTab;
            RepeaterNum3.DataBind();
        }
    }

    //PICK Data to GOTO
    protected void GOTO_Click(object sender, EventArgs e)
    {
        if (LeadershipDisplay.Items.FindByValue("Scholarships").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum1.DataSource = set.dbScholarships;
            RepeaterNum1.DataBind();
            ScholarshipsTableShow.Visible = true;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = false;
            SubmitDiv.Visible = true;
            SortShow.Visible = true;
            EstablishedShow.Visible = true;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbScholarships;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("Founders").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum2.DataSource = set.dbFounders;
            RepeaterNum2.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = true;
            SocietyTableShow.Visible = false;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = true;
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbFounders;
            RepeaterNum2.DataBind();

        }
        else if (LeadershipDisplay.Items.FindByValue("CornerstoneTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbCornerstone;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbCornerstone;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("RoundtableTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbRoundtable;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbRoundtable;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("PresidentsTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbPresidentsTab;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbPresidentsTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("QuadrangleTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbQuadrangleTab;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbQuadrangleTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlueGoldTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbBlueGoldTab;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbBlueGoldTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CenturyTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbCenturyTab;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbCenturyTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("OtherDonorsTab").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbOtherDonorsTab;
            RepeaterNum3.DataBind();
            ScholarshipsTableShow.Visible = false;
            FoundersTableShow.Visible = false;
            SocietyTableShow.Visible = true;
            SubmitDiv.Visible = true;
            SortShow.Visible = false;
            EstablishedShow.Visible = false;
            StatusShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = set.dbOtherDonorsTab;
            RepeaterNum3.DataBind();
        }
    }

    //DELETE Data from Recognition Tables
    protected void DeleteLink_Click(object sender, EventArgs e)
    {
        Call_Database deleteEntry = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("Scholarships").Selected == true)
        {
            string Action = "ScholarshipsDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbScholarships;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("Founders").Selected == true)
        {
            string Action = "FoundersDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbFounders;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CornerstoneTab").Selected == true)
        {
            string Action = "CornerstoneTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCornerstone;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("RoundtableTab").Selected == true)
        {
            string Action = "RoundtableTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbRoundtable;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("PresidentsTab").Selected == true)
        {
            string Action = "PresidentsTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbPresidentsTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("QuadrangleTab").Selected == true)
        {
            string Action = "QuadrangleTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbQuadrangleTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlueGoldTab").Selected == true)
        {
            string Action = "BlueGoldTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlueGoldTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CenturyTab").Selected == true)
        {
            string Action = "CenturyTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCenturyTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("OtherDonorsTab").Selected == true)
        {
            string Action = "OtherDonorsTabDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbOtherDonorsTab;
            RepeaterNum3.DataBind();
        }
    }

    //Repeater Controls for Recognition Tables
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

        if (LeadershipDisplay.Items.FindByValue("Scholarships").Selected == true)
        {
            item.FindControl("sortLabel").Visible = !isEdit;
            item.FindControl("EditSort").Visible = isEdit;
            item.FindControl("establishedLabel").Visible = !isEdit;
            item.FindControl("EditEstablished").Visible = isEdit;

        }
        else if (LeadershipDisplay.Items.FindByValue("Founders").Selected == true)
        {
            item.FindControl("statusLabel").Visible = !isEdit;
            item.FindControl("EditStatus").Visible = isEdit;
        }
    }

    //UPDATE Data to Recognition Tables
    protected void OnUpdate_Click(object sender, EventArgs e)
    {
        Call_Database updateEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;

        if (LeadershipDisplay.Items.FindByValue("Scholarships").Selected == true)
        {
            string Action = "ScholarshipsUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditSort = (item.FindControl("EditSort") as TextBox).Text;
            string EditEstablished = (item.FindControl("EditEstablished") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditSort, EditName, EditEstablished, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbScholarships;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("Founders").Selected == true)
        {
            string Action = "FoundersUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditStatus = (item.FindControl("EditStatus") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, EditStatus, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbFounders;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CornerstoneTab").Selected == true)
        {
            string Action = "CornerstoneTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCornerstone;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("RoundtableTab").Selected == true)
        {
            string Action = "RoundtableTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbRoundtable;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("PresidentsTab").Selected == true)
        {
            string Action = "PresidentsTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbPresidentsTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("QuadrangleTab").Selected == true)
        {
            string Action = "QuadrangleTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbQuadrangleTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlueGoldTab").Selected == true)
        {
            string Action = "BlueGoldTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlueGoldTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CenturyTab").Selected == true)
        {
            string Action = "CenturyTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCenturyTab;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("OtherDonorsTab").Selected == true)
        {
            string Action = "OtherDonorsTabUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbOtherDonorsTab;
            RepeaterNum3.DataBind();
        }
    }
}