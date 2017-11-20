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

    Call_Database conn = new Call_Database();

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void UPLOADData_Click(object sender, EventArgs e)
    {
        string excelPath = Server.MapPath("../Files/") + Path.GetFileName(FileUploadID.PostedFile.FileName);
        FileUploadID.SaveAs(excelPath);

        string conString = string.Empty;
        string extension = Path.GetExtension(FileUploadID.PostedFile.FileName).ToLower();
        switch (extension)
        {
            case ".xls": //Excel 97-03
                conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                break;
            case ".xlsx": //Excel 07 or higher
                conString = ConfigurationManager.ConnectionStrings["Excel07+ConString"].ConnectionString;
                break;

        }

        conString = string.Format(conString, excelPath);
        using (OleDbConnection excel_con = new OleDbConnection(conString))
        {
            excel_con.Open();
            string sheet1 = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();
            DataTable dtExcelData = new DataTable();
            //Recognition Upload
            if (RecognitionUpload.Visible == true)
            {
                if (RecognitionUpload.Items.FindByValue("Scholarships").Selected == true)
                {
                    conn.Connect(FileUploadID, "Scholarships");
            }

                else if (RecognitionUpload.Items.FindByValue("Founders").Selected == true)
                {
                    conn.Connect(FileUploadID, "Founders");
                }

                else if (RecognitionUpload.Items.FindByValue("CornerstoneTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "CornerstoneTab");
                }

                else if (RecognitionUpload.Items.FindByValue("RoundtableTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "RoundtableTab");
                }

                else if (RecognitionUpload.Items.FindByValue("PresidentsTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "PresidentsTab");
                }

                else if (RecognitionUpload.Items.FindByValue("QuadrangleTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "QuadrangleTab");
                }

                else if (RecognitionUpload.Items.FindByValue("BlueGoldTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "BlueGoldTab");
                }

                else if (RecognitionUpload.Items.FindByValue("CenturyTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "CenturyTab");
                }

                else if (RecognitionUpload.Items.FindByValue("OtherDonorsTab").Selected == true)
                {
                    conn.Connect(FileUploadID, "OtherDonorsTab");
                }
                //Recognition End
            }
            //Leadership Here
            else if (LeadershipUpload.Visible == true)
            {
                if (LeadershipUpload.Items.FindByValue("AdvBoard").Selected == true)
                {
                    conn.Connect(FileUploadID, "AdvBoard");
                }

                else if (LeadershipUpload.Items.FindByValue("ElecBoard").Selected == true)
                {
                    conn.Connect(FileUploadID, "ElecBoard");
                }
            }
            //Leadership END
            //MAP START
            else if (MapDataUpload.Visible == true)
            {
                if (LeadershipUpload.Items.FindByValue("OutdoorsInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "OutdoorsInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("ChapelInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "ChapelInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("CommonsInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "CommonsInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("FisherHallInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "FisherHallInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("FitnessCenterInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "FitnessCenterInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("LibraryInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "LibraryInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("ResHallInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "ResHallInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("SwartsHallInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "SwartsHallInfo");
                }

                else if (LeadershipUpload.Items.FindByValue("BlaisdellHallInfo").Selected == true)
                {
                    conn.Connect(FileUploadID, "BlaisdellHallInfo");
                }
            }
        //MAP END
        }
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