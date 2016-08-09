using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Call_Database
/// </summary>
public class Call_Database
{
    private const string conn = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DonorsRec.mdf;Integrated Security = True";
    public DataTable Advdt;
    private DataTable _Advdt;
    public DataTable Elecdt;
    private DataTable _Elecdt;
    public DataTable dtDonors;
    private DataTable _dtDonors;
    public DataTable dtFounders;
    private DataTable _dtFounders;
    public DataTable dtScholarships;
    private DataTable _dtScholarships;
    public DataTable dtCornerstone;
    private DataTable _dtCornerstone;
    public DataTable dtRoundtable;
    private DataTable _dtRoundtable;
    public DataTable dtPresidentsTab;
    private DataTable _dtPresidentsTab;
    public DataTable dtQuadrangleTab;
    private DataTable _dtQuadrangleTab;
    public DataTable dtBlueGoldTab;
    private DataTable _dtBlueGoldTab;
    public DataTable dtCenturyTab;
    private DataTable _dtCenturyTab;
    public DataTable dtOtherDonorsTab;
    private DataTable _dtOtherDonorsTab;

    /// <summary>
    /// Donors Map Datatables are as follows
    /// </summary>
    /// Fisher Hall
    /// public DataTable Test;
    /// private DataTable _Test;
    public DataTable dtFisherHall;
    private DataTable _dtFisherHall;
    public DataTable dtCommons;
    private DataTable _dtCommons;
    public DataTable dtLibrary;
    private DataTable _dtLibrary;
    public DataTable dtSwartsHall;
    private DataTable _dtSwartsHall;
    public DataTable dtBlaisdellHall;
    private DataTable _dtBlaisdellHall;
    public DataTable dtFitnessCenter;
    private DataTable _dtFitnessCenter;
    public DataTable dtResidence;
    private DataTable _dtResidence;
    public DataTable dtOutdoors;
    private DataTable _dtOutdoors;
    public DataTable dtChapelBuilding;
    private DataTable _dtChapelBuilding;
    public DataTable dtChapel;
    private DataTable _dtChapel;
    /// <summary>
    /// Chapel Wall
    /// </summary>
    public DataTable dtHarmonyWall;
    private DataTable _dtHarmonyWall;
    public DataTable dtHopeWall;
    private DataTable _dtHopeWall;
    public DataTable dtFaithWall;
    private DataTable _dtFaithWall;
    public DataTable dtGraceWall;
    private DataTable _dtGraceWall;
    public DataTable dtPeaceWall;
    private DataTable _dtPeaceWall;
    public DataTable dtChairsBenches;
    private DataTable _dtChairsBenches;

    public Call_Database()
    {
        DataTable Advdt = new DataTable();
        DataTable Elecdt = new DataTable();
        DataTable dtDonors = new DataTable();
        DataTable dtFounders = new DataTable();
        DataTable dtScholarships = new DataTable();
        DataTable dtCornerstone = new DataTable();
        DataTable dtRoundtable = new DataTable();
        DataTable dtPresidentsTab = new DataTable();
        DataTable dtQuadrangleTab = new DataTable();
        DataTable dtBlueGoldTab = new DataTable();
        DataTable dtCenturyTab = new DataTable();
        DataTable dtOtherDonorsTab = new DataTable();
        LoadAdv(Advdt);
        _Advdt = Advdt;
        LoadElec(Elecdt);
        _Elecdt = Elecdt;
        LoadDonors(dtDonors);
        _dtDonors = dtDonors;
        LoadFounders(dtFounders);
        _dtFounders = dtFounders;
        LoadScholarships(dtScholarships);
        _dtScholarships = dtScholarships;
        LoadRoundtable(dtRoundtable);
        _dtRoundtable = dtRoundtable;
        LoadCornerstone(dtCornerstone);
        _dtCornerstone = dtCornerstone;
        LoadPresidentsTab(dtPresidentsTab);
        _dtPresidentsTab = dtPresidentsTab;
        LoadQuadrangleTab(dtQuadrangleTab);
        _dtQuadrangleTab = dtQuadrangleTab;
        LoadBlueGoldTab(dtBlueGoldTab);
        _dtBlueGoldTab = dtBlueGoldTab;
        LoadCenturyTab(dtCenturyTab);
        _dtCenturyTab = dtCenturyTab;
        LoadOtherDonorsTab(dtOtherDonorsTab);
        _dtOtherDonorsTab = dtOtherDonorsTab;

        ///Following is new Definitions for Donors_Map
        DataTable dtFisherHall = new DataTable();
        LoadFisherHall(dtFisherHall);
        _dtFisherHall = dtFisherHall;
        DataTable dtCommons = new DataTable();
        LoadCommons(dtCommons);
        _dtCommons = dtCommons;
        DataTable dtLibrary = new DataTable();
        LoadLibrary(dtLibrary);
        _dtLibrary = dtLibrary;
        DataTable dtSwartsHall = new DataTable();
        LoadSwartsHall(dtSwartsHall);
        _dtSwartsHall = dtSwartsHall;
        DataTable dtBlaisdellHall = new DataTable();
        LoadBlaisdellHall(dtBlaisdellHall);
        _dtBlaisdellHall = dtBlaisdellHall;
        DataTable dtFitnessCenter = new DataTable();
        LoadFitnessCenter(dtFitnessCenter);
        _dtFitnessCenter = dtFitnessCenter;
        DataTable dtResidence = new DataTable();
        LoadResidence(dtResidence);
        _dtResidence = dtResidence;
        DataTable dtOutdoors = new DataTable();
        LoadOutdoors(dtOutdoors);
        _dtOutdoors = dtOutdoors;
        DataTable dtChapelBuilding = new DataTable();
        LoadChapelBuilding(dtChapelBuilding);
        _dtChapelBuilding = dtChapelBuilding;
        DataTable dtHarmonyWall = new DataTable();
        LoadHarmonyWall(dtHarmonyWall);
        _dtHarmonyWall = dtHarmonyWall;
        DataTable dtHopeWall = new DataTable();
        LoadHopeWall(dtHopeWall);
        _dtHopeWall = dtHopeWall;
        DataTable dtFaithWall = new DataTable();
        LoadFaithWall(dtFaithWall);
        _dtFaithWall = dtFaithWall;
        DataTable dtGraceWall = new DataTable();
        LoadGraceWall(dtGraceWall);
        _dtGraceWall = dtGraceWall;
        DataTable dtPeaceWall = new DataTable();
        LoadPeaceWall(dtPeaceWall);
        _dtPeaceWall = dtPeaceWall;
        DataTable dtChairsBenches = new DataTable();
        LoadChairsBenches(dtChairsBenches);
        _dtChairsBenches = dtChairsBenches;
        DataTable dtChapel = new DataTable();
        LoadChapel(dtChapel);
        _dtChapel = dtChapel;
    }

    public DataTable AdvBoard
        {
        get{ return _Advdt; }
        set{ _Advdt = value; }
         }
    public DataTable ElecBoard
    {
        get { return _Elecdt; }
        set { _Elecdt = value; }
    }

    public DataTable dbDonors
    {
        get { return _dtDonors; }
        set { _dtDonors = value;}
    }

    public DataTable dbFounders
    {
        get { return _dtFounders; }
        set { _dtFounders = value; }
    }
    public DataTable dbScholarships
    {
        get { return _dtScholarships; }
        set { _dtScholarships = value; }
    }
    public DataTable dbRoundtable
    {
        get { return _dtRoundtable; }
        set { _dtRoundtable = value; }
    }
    public DataTable dbCornerstone
    {
        get { return _dtCornerstone; }
        set { _dtCornerstone = value; }
    }
    public DataTable dbPresidentsTab
    {
        get { return _dtPresidentsTab; }
        set { _dtPresidentsTab = value; }
    }
    public DataTable dbQuadrangleTab
    {
        get { return _dtQuadrangleTab; }
        set { _dtQuadrangleTab = value; }
    }
    public DataTable dbBlueGoldTab
    {
        get { return _dtBlueGoldTab; }
        set { _dtBlueGoldTab = value; }
    }
    public DataTable dbCenturyTab
    {
        get { return _dtCenturyTab; }
        set { _dtCenturyTab = value; }
    }
    public DataTable dbOtherDonorsTab
    {
        get { return _dtOtherDonorsTab; }
        set { _dtOtherDonorsTab = value; }
    }

    /// <summary>
    /// Donors Map Datatable Get:Set
    /// </summary>

    public DataTable dbFisherHall
    {
        get { return _dtFisherHall; }
        set { _dtFisherHall = value; }
    }

    public DataTable dbCommons
    {
        get { return _dtCommons; }
        set { _dtCommons = value; }
    }

    public DataTable dbLibrary
    {
        get { return _dtLibrary; }
        set { _dtLibrary = value; }
    }

    public DataTable dbSwartsHall
    {
        get { return _dtSwartsHall; }
        set { _dtSwartsHall = value; }
    }

    public DataTable dbBlaisdellHall
    {
        get { return _dtBlaisdellHall; }
        set { _dtBlaisdellHall = value; }
    }

    public DataTable dbFitnessCenter
    {
        get { return _dtFitnessCenter; }
        set { _dtFitnessCenter = value; }
    }

    public DataTable dbResidence
    {
        get { return _dtResidence; }
        set { _dtResidence = value; }
    }

    public DataTable dbOutdoors
    {
        get { return _dtOutdoors; }
        set { _dtOutdoors = value; }
    }

    /// <summary>
    /// Chapel Datatable Sets
    /// </summary>

    public DataTable dbChapel
    {
        get { return _dtChapel; }
        set { _dtChapel = value; }
    }

    public DataTable dbChapelBuilding
    {
        get { return _dtChapelBuilding; }
        set { _dtChapelBuilding = value; }
    }

    public DataTable dbHarmonyWall
    {
        get { return _dtHarmonyWall; }
        set { _dtHarmonyWall = value; }
    }

    public DataTable dbHopeWall
    {
        get { return _dtHopeWall; }
        set { _dtHopeWall = value; }
    }

    public DataTable dbFaithWall
    {
        get { return _dtFaithWall; }
        set { _dtFaithWall = value; }
    }

    public DataTable dbGraceWall
    {
        get { return _dtGraceWall; }
        set { _dtGraceWall = value; }
    }

    public DataTable dbPeaceWall
    {
        get { return _dtPeaceWall; }
        set { _dtPeaceWall = value; }
    }

    public DataTable dbChairsBenches
    {
        get { return _dtChairsBenches; }
        set { _dtChairsBenches = value; }
    }

    /// <summary>
    /// Basic Commands for Database
    /// </summary>
    /// Universal DELETE Method
    public void Delete(int deleteId, string Action)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            using (SqlCommand CmdSql = new SqlCommand("ProcDELETE"))
            {
                CmdSql.CommandType = CommandType.StoredProcedure;
                CmdSql.Parameters.AddWithValue("@Action", Action);
                CmdSql.Parameters.AddWithValue("@ProcedureId", deleteId);
                CmdSql.Connection = conn;
                conn.Open();
                CmdSql.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
    
    /// Universal INSERT Method
    public void FormINSERT(string Action = null, string FormVar1 = null, string FormVar2 = null, string FormVar3 = null, string FormVar4 = null, string FormVar5 = null, int FormInt1 = 0, int FormInt2 = 0, int FormInt3 = 0, float FormFloat1 = 0)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            //Testimonials Page INSERT
            if (Action == "DonorsINSERT")
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [donors] (name, photo, profile) VALUES (@name, @photo, @profile)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", FormVar1);
                CmdSql.Parameters.AddWithValue("@photo", "Images/dbImages/" + FormVar2);
                CmdSql.Parameters.AddWithValue("@profile", FormVar3);
                CmdSql.ExecuteNonQuery();
                conn.Close();
            }
            //Leadership Page INSERT
            else if (Action == "AdvBoardINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcLeadershipADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@LeadershipName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@LeadershipStatus", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }

            }
            else if (Action == "ElecBoardINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcLeadershipADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@LeadershipName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@LeadershipYear", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            // Recognition Page INSERT
            // SCHOLARSHIP TABLE INSERT
            else if (Action == "ScholarshipsINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ScholarSort", FormVar1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@Established", FormVar3);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            // FOUNDERS TABLE INSERT
            else if (Action == "FoundersINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@RecStatus", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //CORNERSTONE SOCIETY TABLE INSERT
            else if (Action == "CornerstoneTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //ROUNDTABLE SOCIETY TABLE INSERT
            else if (Action == "RoundtableTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //PRESIDENT'S SOCIETY TABLE INSERT
            else if (Action == "PresidentsTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //QUADRANGLE SOCIETY TABLE INSERT
            else if (Action == "QuadrangleTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //BLUE & GOLD SOCIETY TABLE INSERT
            else if (Action == "BlueGoldTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //CENTURY SOCIETY TABLE INSERT
            else if (Action == "CenturyTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //OTHER DONORS TABLE INSERT
            else if (Action == "OtherDonorsTabINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //DONORS MAP PAGE TABLES
            //WICK-CHAPEL TABLE INSERT
            else if (Action == "ChapelInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapLevel", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapSort", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapOrder", FormFloat1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //OUTDOORS TABLE INSERT
            else if (Action == "OutdoorsInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapLocation", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapArea", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar4);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar5);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //FISHER HALL TABLE INSERT
            else if (Action == "FisherHallInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //COMMONS TABLE INSERT
            else if (Action == "CommonsInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //HANLEY LIBRARY TABLE INSERT
            else if (Action == "LibraryInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //SWARTS HALL TABLE INSERT
            else if (Action == "SwartsHallInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //RESIDENCE HALL TABLE INSERT
            else if (Action == "ResHallInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //BLAISDELL HALL TABLE INSERT
            else if (Action == "BlaisdellHallInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //FITNESS CENTER TABLE INSERT
            else if (Action == "FitnessCenterInfoINSERT")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
    
    /// Universal UPDATE Method
    public void FormUPDATE(string Action = null, string FormVar1 = null, string FormVar2 = null, string FormVar3 = null, string FormVar4 = null, string FormVar5 = null, int FormInt1 = 0, int FormInt2 = 0, int FormInt3 = 0, float FormFloat1 = 0)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            //TESTIMONIALS PAGE UPDATE
            //DONORS TABLE UPDATE
            if (Action == "DonorsUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcDonorADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@DonorName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@DonorPhoto", FormVar2);
                    CmdSql.Parameters.AddWithValue("@DonorProfile", FormVar3);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //LEADERSHIP PAGE UPDATE
            //AdvBoard TABLE UPDATE
            else if (Action == "AdvBoardUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcLeadershipADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@LeadershipName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@LeadershipStatus", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //ElecBoard TABLE UPDATE
            else if (Action == "ElecBoardUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcLeadershipADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@LeadershipName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@LeadershipYear", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            // Recognition Page UPDATE
            // SCHOLARSHIP TABLE UPDATE
            else if (Action == "ScholarshipsUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@ScholarSort", FormVar1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@Established", FormVar3);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            // FOUNDERS TABLE TABLE UPDATE
            else if (Action == "FoundersUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Parameters.AddWithValue("@RecStatus", FormVar2);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //CORNERSTONE SOCIETY TABLE UPDATE
            else if (Action == "CornerstoneTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //ROUNDTABLE SOCIETY TABLE UPDATE
            else if (Action == "RoundtableTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //PRESIDENT'S SOCIETY TABLE UPDATE
            else if (Action == "PresidentsTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //QUADRANGLE SOCIETY TABLE UPDATE
            else if (Action == "QuadrangleTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //BLUE & GOLD SOCIETY TABLE UPDATE
            else if (Action == "BlueGoldTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //CENTURY SOCIETY TABLE UPDATE
            else if (Action == "CenturyTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //OTHER DONORS TABLE UPDATE
            else if (Action == "OtherDonorsTabUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcRecognitionADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@RecName", FormVar1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //DONORS MAP PAGE TABLES UPDATE
            //WICK-CHAPEL TABLE UPDATE
            else if (Action == "ChapelInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapLevel", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapSort", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapOrder", FormFloat1);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //OUTDOORS TABLE UPDATE
            else if (Action == "OutdoorsInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapLocation", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapArea", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar4);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar5);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //FISHER HALL TABLE UPDATE
            else if (Action == "FisherHallInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //COMMONS TABLE UPDATE
            else if (Action == "CommonsInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //HANLEY LIBRARY TABLE UPDATE
            else if (Action == "LibraryInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //SWARTS HALL TABLE UPDATE
            else if (Action == "SwartsHallInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //RESIDENCE HALL TABLE UPDATE
            else if (Action == "ResHallInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //BLAISDELL HALL TABLE UPDATE
            else if (Action == "BlaisdellHallInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //FITNESS CENTER TABLE UPDATE
            else if (Action == "FitnessCenterInfoUPDATE")
            {
                using (SqlCommand CmdSql = new SqlCommand("ProcMapADD_UPDATE"))
                {
                    CmdSql.CommandType = CommandType.StoredProcedure;
                    CmdSql.Parameters.AddWithValue("@Action", Action);
                    CmdSql.Parameters.AddWithValue("@ProcedureId", FormInt1);
                    CmdSql.Parameters.AddWithValue("@MapId", FormVar1);
                    CmdSql.Parameters.AddWithValue("@MapName", FormVar2);
                    CmdSql.Parameters.AddWithValue("@MapPlaque", FormVar3);
                    CmdSql.Parameters.AddWithValue("@MapDate", FormVar4);
                    CmdSql.Connection = conn;
                    conn.Open();
                    CmdSql.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }


    /// <summary>
    /// Database Load Connections
    /// </summary>

    public void LoadAdv(DataTable Advdt)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM AdvBoard";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drAdvBoard;
        conn.Open();
        drAdvBoard = cmd.ExecuteReader();
        Advdt.Load(drAdvBoard);
        conn.Close();
    }

    public void LoadElec(DataTable Elecdt)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ElecBoard";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drElecBoard;
        conn.Open();
        drElecBoard = cmd.ExecuteReader();
        Elecdt.Load(drElecBoard);
        conn.Close();
    }

    public void LoadDonors(DataTable dtDonors)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM donors";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drDonors;
        conn.Open();
        drDonors = cmd.ExecuteReader();
        dtDonors.Load(drDonors);
        conn.Close();
    }

    public void LoadFounders(DataTable dtFounders)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM Founders";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFounders;
        conn.Open();
        drFounders = cmd.ExecuteReader();
        dtFounders.Load(drFounders);
        conn.Close();
    }

    public void LoadScholarships(DataTable dtScholarships)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM Scholarships";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drScholarships;
        conn.Open();
        drScholarships = cmd.ExecuteReader();
        dtScholarships.Load(drScholarships);
        conn.Close();
    }

    public void LoadCornerstone(DataTable dtCornerstone)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CornerstoneTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCornerstone;
        conn.Open();
        drCornerstone = cmd.ExecuteReader();
        dtCornerstone.Load(drCornerstone);
        conn.Close();
    }

    public void LoadRoundtable(DataTable dtRoundtable)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM RoundtableTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drRoundtable;
        conn.Open();
        drRoundtable = cmd.ExecuteReader();
        dtRoundtable.Load(drRoundtable);
        conn.Close();
    }

    public void LoadPresidentsTab(DataTable dtPresidentsTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM PresidentsTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drPresidentsTab;
        conn.Open();
        drPresidentsTab = cmd.ExecuteReader();
        dtPresidentsTab.Load(drPresidentsTab);
        conn.Close();
    }

    public void LoadQuadrangleTab(DataTable dtQuadrangleTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM QuadrangleTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drQuadrangleTab;
        conn.Open();
        drQuadrangleTab = cmd.ExecuteReader();
        dtQuadrangleTab.Load(drQuadrangleTab);
        conn.Close();
    }

    public void LoadBlueGoldTab(DataTable dtBlueGoldTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM BlueGoldTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drBlueGoldTab;
        conn.Open();
        drBlueGoldTab = cmd.ExecuteReader();
        dtBlueGoldTab.Load(drBlueGoldTab);
        conn.Close();
    }

    public void LoadCenturyTab(DataTable dtCenturyTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CenturyTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCenturyTab;
        conn.Open();
        drCenturyTab = cmd.ExecuteReader();
        dtCenturyTab.Load(drCenturyTab);
        conn.Close();
    }

    public void LoadOtherDonorsTab(DataTable dtOtherDonorsTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM OtherDonorsTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drOtherDonorsTab;
        conn.Open();
        drOtherDonorsTab = cmd.ExecuteReader();
        dtOtherDonorsTab.Load(drOtherDonorsTab);
        conn.Close();
    }

    ///Donors_Map Load Connections
    public void LoadFisherHall(DataTable dtFisherHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM FisherHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFisherHall;
        conn.Open();
        drFisherHall = cmd.ExecuteReader();
        dtFisherHall.Load(drFisherHall);
        conn.Close();
    }

    public void LoadCommons(DataTable dtCommons)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CommonsInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCommons;
        conn.Open();
        drCommons = cmd.ExecuteReader();
        dtCommons.Load(drCommons);
        conn.Close();
    }

    public void LoadLibrary(DataTable dtLibrary)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM LibraryInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drLibrary;
        conn.Open();
        drLibrary = cmd.ExecuteReader();
        dtLibrary.Load(drLibrary);
        conn.Close();
    }

    public void LoadSwartsHall(DataTable dtSwartsHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM SwartsHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drSwartsHall;
        conn.Open();
        drSwartsHall = cmd.ExecuteReader();
        dtSwartsHall.Load(drSwartsHall);
        conn.Close();
    }

    public void LoadBlaisdellHall(DataTable dtBlaisdellHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM BlaisdellHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drBlaisdellHall;
        conn.Open();
        drBlaisdellHall = cmd.ExecuteReader();
        dtBlaisdellHall.Load(drBlaisdellHall);
        conn.Close();
    }

    public void LoadFitnessCenter(DataTable dtFitnessCenter)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM FitnessCenterInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFitnessCenter;
        conn.Open();
        drFitnessCenter = cmd.ExecuteReader();
        dtFitnessCenter.Load(drFitnessCenter);
        conn.Close();
    }

    public void LoadResidence(DataTable dtResidence)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ResHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drResidence;
        conn.Open();
        drResidence = cmd.ExecuteReader();
        dtResidence.Load(drResidence);
        conn.Close();
    }

    public void LoadOutdoors(DataTable dtOutdoors)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM OutdoorsInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drOutdoors;
        conn.Open();
        drOutdoors = cmd.ExecuteReader();
        dtOutdoors.Load(drOutdoors);
        conn.Close();
    }

    public void LoadChapelBuilding(DataTable dtChapelBuilding)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Building' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelBuilding;
        conn.Open();
        drChapelBuilding = cmd.ExecuteReader();
        dtChapelBuilding.Load(drChapelBuilding);
        conn.Close();
    }

    /// <summary>
    /// Chapel Donors Wall
    /// </summary>

    public void LoadHarmonyWall(DataTable dtHarmonyWall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Donors' AND Level = 'Harmony' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelWall;
        conn.Open();
        drChapelWall = cmd.ExecuteReader();
        dtHarmonyWall.Load(drChapelWall);
        conn.Close();
    }

    public void LoadHopeWall(DataTable dtHopeWall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Donors' AND Level = 'Hope' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelWall;
        conn.Open();
        drChapelWall = cmd.ExecuteReader();
        dtHopeWall.Load(drChapelWall);
        conn.Close();
    }

    public void LoadFaithWall(DataTable dtFaithWall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Donors' AND Level = 'Faith' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelWall;
        conn.Open();
        drChapelWall = cmd.ExecuteReader();
        dtFaithWall.Load(drChapelWall);
        conn.Close();
    }

    public void LoadGraceWall(DataTable dtGraceWall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Donors' AND Level = 'Grace' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelWall;
        conn.Open();
        drChapelWall = cmd.ExecuteReader();
        dtGraceWall.Load(drChapelWall);
        conn.Close();
    }

    public void LoadPeaceWall(DataTable dtPeaceWall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Sort = 'Donors' AND Level = 'Peace' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelWall;
        conn.Open();
        drChapelWall = cmd.ExecuteReader();
        dtPeaceWall.Load(drChapelWall);
        conn.Close();
    }
    
    public void LoadChairsBenches(DataTable dtChairsBenches)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo WHERE Level = 'Chairs & Benches' ORDER BY ViewOrder";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapel;
        conn.Open();
        drChapel = cmd.ExecuteReader();
        dtChairsBenches.Load(drChapel);
        conn.Close();
    }

    public void LoadChapel(DataTable dtChapel)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ChapelInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drChapelMain;
        conn.Open();
        drChapelMain = cmd.ExecuteReader();
        dtChapel.Load(drChapelMain);
        conn.Close();
    }
}