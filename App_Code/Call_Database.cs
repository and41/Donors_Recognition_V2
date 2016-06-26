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
    public DataTable dtHonorRoll;
    private DataTable _dtHonorRoll;
    public DataTable dtScholarships;
    private DataTable _dtScholarships;

    public Call_Database()
    {
        DataTable Advdt = new DataTable();
        DataTable Elecdt = new DataTable();
        DataTable dtDonors = new DataTable();
        DataTable dtFounders = new DataTable();
        DataTable dtHonorRoll = new DataTable();
        DataTable dtScholarships = new DataTable();
        LoadAdv(Advdt);
        _Advdt = Advdt;
        LoadElec(Elecdt);
        _Elecdt = Elecdt;
        LoadDonors(dtDonors);
        _dtDonors = dtDonors;
        LoadFounders(dtFounders);
        _dtFounders = dtFounders;
        LoadHonorRoll(dtHonorRoll);
        _dtHonorRoll = dtHonorRoll;
        LoadScholarships(dtScholarships);
        _dtScholarships = dtScholarships;
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
    public DataTable dbHonorRoll
    {
        get { return _dtHonorRoll; }
        set { _dtHonorRoll = value; }
    }
    public DataTable dbScholarships
    {
        get { return _dtScholarships; }
        set { _dtScholarships = value; }
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

    public void LoadHonorRoll(DataTable dtHonorRoll)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM HonorRoll";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drHonorRoll;
        conn.Open();
        drHonorRoll = cmd.ExecuteReader();
        dtHonorRoll.Load(drHonorRoll);
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
}