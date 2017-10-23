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

public partial class ContentPages_UploadDrop : System.Web.UI.Page
{
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
                    dtExcelData.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)), new DataColumn("Sort", typeof(string)),
                new DataColumn("Name", typeof(string)), new DataColumn("Established", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.Scholarships";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Sort", "Sort");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            sqlBulkCopy.ColumnMappings.Add("Established", "Established");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("Founders").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)), new DataColumn("Status", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.Founders";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            sqlBulkCopy.ColumnMappings.Add("Status", "Status");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("CornerstoneTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.CornerstoneTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }

                }

                else if (RecognitionUpload.Items.FindByValue("RoundtableTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.RoundtableTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("PresidentsTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.PresidentsTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("QuadrangleTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.QuadrangleTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("BlueGoldTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.BlueGoldTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("CenturyTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.CenturyTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (RecognitionUpload.Items.FindByValue("OtherDonorsTab").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[2] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.OtherDonorsTab";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }
                //Recognition End
            }
            //Leadership Here
            else if (LeadershipUpload.Visible == true)
            {
                if (LeadershipUpload.Items.FindByValue("AdvBoard").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)), new DataColumn("Status", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.AdvBoard";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            sqlBulkCopy.ColumnMappings.Add("Status", "Status");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("ElecBoard").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)), new DataColumn("Year", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.ElecBoard";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            sqlBulkCopy.ColumnMappings.Add("Year", "Year");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }
            }
            //Leadership END
            //MAP START
            else if (MapDataUpload.Visible == true)
            {
                if (LeadershipUpload.Items.FindByValue("OutdoorsInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[6] { new DataColumn("Id", typeof(int)),
                new DataColumn("Location", typeof(string)), new DataColumn("Donor Name", typeof(string)), new DataColumn("Name of Area", typeof(string)),
                    new DataColumn("Wording on Plaque", typeof(string)), new DataColumn("Dedication Date", typeof(string))});

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.OutdoorsInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Location", "Location");
                            sqlBulkCopy.ColumnMappings.Add("Donor Name", "Donor Name");
                            sqlBulkCopy.ColumnMappings.Add("Name of Area", "Name of Area");
                            sqlBulkCopy.ColumnMappings.Add("Wording on Plaque", "Wording on Plaque");
                            sqlBulkCopy.ColumnMappings.Add("Dedication Date", "Dedication Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("ChapelInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("Level", typeof(string)), new DataColumn("Plaque", typeof(string)), new DataColumn("Sort", typeof(string)),
                    new DataColumn("ViewOrder", typeof(float)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.ChapelInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("Level", "Level");
                            sqlBulkCopy.ColumnMappings.Add("Plaque", "Plaque");
                            sqlBulkCopy.ColumnMappings.Add("Sort", "Sort");
                            sqlBulkCopy.ColumnMappings.Add("ViewOrder", "ViewOrder");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("CommonsInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.CommonsInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("FisherHallInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.FisherHallInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("FitnessCenterInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.FitnessCenterInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("LibraryInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.LibraryInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("ResHallInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.ResHallInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("SwartsHallInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.SwartsHallInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
                }

                else if (LeadershipUpload.Items.FindByValue("BlaisdellHallInfo").Selected == true)
                {
                    dtExcelData.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                new DataColumn("RoomId", typeof(string)), new DataColumn("RoomName", typeof(string)), new DataColumn("RoomPlaque", typeof(string)),
                    new DataColumn("Date", typeof(string)) });

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();

                    string consString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(consString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.BlaisdellHallInfo";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("Id", "Id");
                            sqlBulkCopy.ColumnMappings.Add("RoomId", "RoomId");
                            sqlBulkCopy.ColumnMappings.Add("RoomName", "RoomName");
                            sqlBulkCopy.ColumnMappings.Add("RoomPlaque", "RoomPlaque");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            con.Close();
                        }
                    }
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