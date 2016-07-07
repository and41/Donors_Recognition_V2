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


    public void Add(string Namebox, string Imagename, string Profiletxt)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            SqlCommand CmdSql = new SqlCommand("INSERT INTO [donors] (name, photo, profile) VALUES (@name, @photo, @profile)", conn);
            conn.Open();
            CmdSql.Parameters.AddWithValue("@Name", Namebox);
            CmdSql.Parameters.AddWithValue("@photo", "Images/dbImages/" + Imagename);
            CmdSql.Parameters.AddWithValue("@profile", Profiletxt);
            CmdSql.ExecuteNonQuery();
            conn.Close();
        }
    }

    public void Delete(int deleteId)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            SqlCommand CmdSql = new SqlCommand("DELETE FROM [donors] WHERE[Id] = @deleteId",conn);
            conn.Open();
            CmdSql.Parameters.AddWithValue("@deleteId", deleteId);
            CmdSql.ExecuteNonQuery();
            conn.Close();
        }
    }

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
}