using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using OfficeOpenXml;

public partial class ContentPages_UploadDrop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void UPLOADData_Click(object sender, EventArgs e)
    {
        //Recognition Upload
        if (RecognitionUpload.Visible == true)
        {
            if (RecognitionUpload.Items.FindByValue("Scholarships").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "Scholarships");
            }

            else if (RecognitionUpload.Items.FindByValue("Founders").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "Founders");
            }

            else if (RecognitionUpload.Items.FindByValue("CornerstoneTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "CornerstoneTab");
            }

            else if (RecognitionUpload.Items.FindByValue("RoundtableTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "RoundtableTab");
            }

            else if (RecognitionUpload.Items.FindByValue("PresidentsTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "PresidentsTab");
            }

            else if (RecognitionUpload.Items.FindByValue("QuadrangleTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "QuadrangleTab");
            }

            else if (RecognitionUpload.Items.FindByValue("BlueGoldTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "BlueGoldTab");
            }

            else if (RecognitionUpload.Items.FindByValue("CenturyTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "CenturyTab");
            }

            else if (RecognitionUpload.Items.FindByValue("OtherDonorsTab").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "OtherDonorsTab");
            }
            //Recognition End
        }
        //Leadership Here
        else if (LeadershipUpload.Visible == true)
        {
            if (LeadershipUpload.Items.FindByValue("AdvBoard").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "AdvBoard");
            }

            else if (LeadershipUpload.Items.FindByValue("ElecBoard").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "ElecBoard");
            }
        }
        //Leadership END
        //MAP START
        else if (MapDataUpload.Visible == true)
        {
            if (MapDataUpload.Items.FindByValue("OutdoorsInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "OutdoorsInfo");
            }

            else if (MapDataUpload.Items.FindByValue("ChapelInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "ChapelInfo");
            }

            else if (MapDataUpload.Items.FindByValue("CommonsInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "CommonsInfo");
            }

            else if (MapDataUpload.Items.FindByValue("FisherHallInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "FisherHallInfo");
            }

            else if (MapDataUpload.Items.FindByValue("FitnessCenterInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "FitnessCenterInfo");
            }

            else if (MapDataUpload.Items.FindByValue("LibraryInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "LibraryInfo");
            }

            else if (MapDataUpload.Items.FindByValue("ResHallInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "ResHallInfo");
            }

            else if (MapDataUpload.Items.FindByValue("SwartsHallInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "SwartsHallInfo");
            }

            else if (MapDataUpload.Items.FindByValue("BlaisdellHallInfo").Selected == true)
            {
                Call_Database conn = new Call_Database();
                conn.Connect(FileUploadID, "BlaisdellHallInfo");
            }
        }
        //MAP END
    }



    protected void GOTO_Click(object sender, EventArgs e)
    {
        if (TablesDisplay.Items.FindByValue("LeadershipTables").Selected == true)
        {
            LeadershipUpload.Visible = true;
            SelectUpload.Visible = true;
            RecognitionUpload.Visible = false;
            MapDataUpload.Visible = false;
            UploadDiv.Visible = false;
        }
        else if (TablesDisplay.Items.FindByValue("MapTables").Selected == true)
        {
            MapDataUpload.Visible = true;
            SelectUpload.Visible = true;
            LeadershipUpload.Visible = false;
            RecognitionUpload.Visible = false;
            UploadDiv.Visible = false;
        }
        else if (TablesDisplay.Items.FindByValue("RecTables").Selected == true)
        {
            RecognitionUpload.Visible = true;
            SelectUpload.Visible = true;
            LeadershipUpload.Visible = false;
            MapDataUpload.Visible = false;
            UploadDiv.Visible = false;
        }
        /*
        else if (TablesDisplay.Items.FindByValue("TestimonialTables").Selected == true)
        {
            RecognitionUpload.Visible = false;
            SelectUpload.Visible = false;
            LeadershipUpload.Visible = false;
            MapDataUpload.Visible = false;
            UploadDiv.Visible = true;
        }
        */
    }
    protected void UPLOADSelect_Click(object sender, EventArgs e)
    {
        UploadDiv.Visible = false;
        UploadDiv.Visible = true;
    }
}