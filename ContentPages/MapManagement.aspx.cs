using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


public partial class ContentPages_MapManagement : System.Web.UI.Page
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
            RepeaterNum1.DataSource = PageDB.dbOutdoors;
            RepeaterNum1.DataBind();
            //Loads Founders Table
            RepeaterNum2.DataSource = PageDB.dbChapel;
            RepeaterNum2.DataBind();
            //Loads Society Tables
            RepeaterNum3.DataSource = PageDB.dbFisherHall;
            RepeaterNum3.DataBind();
        }
    }

    //INSERT DATA into MAP Tables
    protected void SubButton_Click(object sender, EventArgs e)
    {
        Call_Database callDB = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected == true)
        {
            string Action = "OutdoorsInfoINSERT";
            callDB.FormINSERT(Action, txtLocation.Text, txtName.Text, txtArea.Text, txtPlaque.Text, txtDedication.Text, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbOutdoors;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected == true)
        {
            string Action = "ChapelInfoINSERT";
            float ChapelFloat = float.Parse((OrderShow.FindControl("txtOrder") as TextBox).Text);
            callDB.FormINSERT(Action, txtLevel.Text, txtPlaque.Text, txtSort.Text, null, null, 0, 0, 0, ChapelFloat);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbChapel;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CommonsInfo").Selected == true)
        {
            string Action = "CommonsInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCommons;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FisherHallInfo").Selected == true)
        {
            string Action = "FisherHallInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFisherHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FitnessCenterInfo").Selected == true)
        {
            string Action = "FitnessCenterInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFitnessCenter;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("LibraryInfo").Selected == true)
        {
            string Action = "LibraryInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbLibrary;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ResHallInfo").Selected == true)
        {
            string Action = "ResHallInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbResidence;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("SwartsHallInfo").Selected == true)
        {
            string Action = "SwartsHallInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbSwartsHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlaisdellHallInfo").Selected == true)
        {
            string Action = "BlaisdellHallInfoINSERT";
            callDB.FormINSERT(Action, txtRoomId.Text, txtName.Text, txtPlaque.Text, txtDate.Text, null, 0, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlaisdellHall;
            RepeaterNum3.DataBind();
        }
    }

    //PICK Data with GOTO
    protected void GOTO_Click(object sender, EventArgs e)
    {
        if (LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum1.DataSource = set.dbOutdoors;
            RepeaterNum1.DataBind();
            OutdoorsTableShow.Visible = true;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = false;
            SubmitDiv.Visible = true;

            PlaqueShow.Visible = true;
            LocationShow.Visible = true;
            NameShow.Visible = true;
            AreaShow.Visible = true;
            DedicationShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;

            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbOutdoors;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum2.DataSource = set.dbChapel;
            RepeaterNum2.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = true;
            MapTableShow.Visible = false;
            SubmitDiv.Visible = true;

            LevelShow.Visible = true;
            PlaqueShow.Visible = true;
            SortShow.Visible = true;
            OrderShow.Visible = true;

            LocationShow.Visible = false;
            NameShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbChapel;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CommonsInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbCommons;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCommons;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FisherHallInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbFisherHall;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFisherHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FitnessCenterInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbFitnessCenter;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFitnessCenter;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("LibraryInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbLibrary;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbLibrary;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ResHallInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbResidence;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbResidence;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("SwartsHallInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbSwartsHall;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbSwartsHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlaisdellHallInfo").Selected == true)
        {
            Call_Database set = new Call_Database();
            RepeaterNum3.DataSource = set.dbBlaisdellHall;
            RepeaterNum3.DataBind();
            OutdoorsTableShow.Visible = false;
            ChapelTableShow.Visible = false;
            MapTableShow.Visible = true;
            SubmitDiv.Visible = true;

            RoomIdShow.Visible = true;
            NameShow.Visible = true;
            PlaqueShow.Visible = true;
            DateShow.Visible = true;

            LevelShow.Visible = false;
            SortShow.Visible = false;
            OrderShow.Visible = false;
            LocationShow.Visible = false;
            AreaShow.Visible = false;
            DedicationShow.Visible = false;
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlaisdellHall;
            RepeaterNum3.DataBind();
        }
    }

    //DELETE Data from Tables
    protected void DeleteLink_Click(object sender, EventArgs e)
    {
        Call_Database deleteEntry = new Call_Database();

        if (LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected == true)
        {
            string Action = "OutdoorsInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbOutdoors;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected == true)
        {
            string Action = "ChapelInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbChapel;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CommonsInfo").Selected == true)
        {
            string Action = "CommonsInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCommons;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FisherHallInfo").Selected == true)
        {
            string Action = "FisherHallInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFisherHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FitnessCenterInfo").Selected == true)
        {
            string Action = "FitnessCenterInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFitnessCenter;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("LibraryInfo").Selected == true)
        {
            string Action = "LibraryInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbLibrary;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ResHallInfo").Selected == true)
        {
            string Action = "ResHallInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbResidence;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("SwartsHallInfo").Selected == true)
        {
            string Action = "SwartsHallInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbSwartsHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlaisdellHallInfo").Selected == true)
        {
            string Action = "BlaisdellHallInfoDELETE";
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
            deleteEntry.Delete(deleteId, Action);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlaisdellHall;
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

        if (LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected == true)
        {
            item.FindControl("locationLabel").Visible = !isEdit;
            item.FindControl("EditLocation").Visible = isEdit;
            item.FindControl("nameLabel").Visible = !isEdit;
            item.FindControl("EditName").Visible = isEdit;
            item.FindControl("areaLabel").Visible = !isEdit;
            item.FindControl("EditArea").Visible = isEdit;
            item.FindControl("plaqueLabel").Visible = !isEdit;
            item.FindControl("EditPlaque").Visible = isEdit;
            item.FindControl("dedicationLabel").Visible = !isEdit;
            item.FindControl("EditDedication").Visible = isEdit;
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected == true)
        {
            item.FindControl("levelLabel").Visible = !isEdit;
            item.FindControl("EditLevel").Visible = isEdit;
            item.FindControl("plaqueLabel").Visible = !isEdit;
            item.FindControl("EditPlaque").Visible = isEdit;
            item.FindControl("sortLabel").Visible = !isEdit;
            item.FindControl("EditSort").Visible = isEdit;
            item.FindControl("orderLabel").Visible = !isEdit;
            item.FindControl("EditOrder").Visible = isEdit;
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected != true && LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected != true)
        {
            item.FindControl("roomidLabel").Visible = !isEdit;
            item.FindControl("EditRoomId").Visible = isEdit;
            item.FindControl("nameLabel").Visible = !isEdit;
            item.FindControl("EditName").Visible = isEdit;
            item.FindControl("plaqueLabel").Visible = !isEdit;
            item.FindControl("EditPlaque").Visible = isEdit;
            item.FindControl("DateLabel").Visible = !isEdit;
            item.FindControl("EditDate").Visible = isEdit;
        }
    }

    //UPDATE DATA from TABLES
    protected void OnUpdate_Click(object sender, EventArgs e)
    {
        Call_Database updateEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;

        if (LeadershipDisplay.Items.FindByValue("OutdoorsInfo").Selected == true)
        {
            string Action = "OutdoorsInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditLocation = (item.FindControl("EditLocation") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditArea = (item.FindControl("EditArea") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDedication = (item.FindControl("EditDedication") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditLocation, EditName, EditArea, EditPlaque, EditDedication, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum1.DataSource = update.dbOutdoors;
            RepeaterNum1.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ChapelInfo").Selected == true)
        {
            string Action = "ChapelInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            float EditOrder = float.Parse((OrderShow.FindControl("EditOrder") as TextBox).Text);
            string EditLevel = (item.FindControl("EditLevel") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditSort = (item.FindControl("EditSort") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditLevel, EditPlaque, EditSort, null, null, updateId, 0, 0, EditOrder);
            Call_Database update = new Call_Database();
            RepeaterNum2.DataSource = update.dbChapel;
            RepeaterNum2.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("CommonsInfo").Selected == true)
        {
            string Action = "CommonsInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbCommons;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FisherHallInfo").Selected == true)
        {
            string Action = "FisherHallInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFisherHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("FitnessCenterInfo").Selected == true)
        {
            string Action = "FitnessCenterInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbFitnessCenter;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("LibraryInfo").Selected == true)
        {
            string Action = "LibraryInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbLibrary;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("ResHallInfo").Selected == true)
        {
            string Action = "ResHallInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbResidence;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("SwartsHallInfo").Selected == true)
        {
            string Action = "SwartsHallInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbSwartsHall;
            RepeaterNum3.DataBind();
        }
        else if (LeadershipDisplay.Items.FindByValue("BlaisdellHallInfo").Selected == true)
        {
            string Action = "BlaisdellHallInfoUPDATE";
            int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
            string EditRoomId = (item.FindControl("EditRoomId") as TextBox).Text;
            string EditName = (item.FindControl("EditName") as TextBox).Text;
            string EditPlaque = (item.FindControl("EditPlaque") as TextBox).Text;
            string EditDate = (item.FindControl("EditDate") as TextBox).Text;
            updateEntry.FormUPDATE(Action, EditRoomId, EditName, EditPlaque, EditDate, null, updateId, 0, 0, 0);
            Call_Database update = new Call_Database();
            RepeaterNum3.DataSource = update.dbBlaisdellHall;
            RepeaterNum3.DataBind();
        }
    }
}