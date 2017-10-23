using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class ContentPages_TestimonialManagement : System.Web.UI.Page
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
            Call_Database AlumniDB = new Call_Database();
            RepeaterNum.DataSource = PageDB.dbDonors;
            RepeaterNum.DataBind();
            RepeaterNum2.DataSource = AlumniDB.dbAlumniMap;
            RepeaterNum2.DataBind();
        }
    }

    //Checks file type submitted into dbImages
    protected bool CheckFileType(string strFileName)
    {

        string strExt = System.IO.Path.GetExtension(strFileName).ToLower();
        bool isGraphic = false;

        switch (strExt)
        {
            case ".bmp":
                isGraphic = true;
                break;
            case ".jpg":
                isGraphic = true;
                break;
            case ".gif":
                isGraphic = true;
                break;
            case ".jpeg":
                isGraphic = true;
                break;
            case ".png":
                isGraphic = true;
                break;
            default:
                isGraphic = false;
                break;
        }
        return isGraphic;
    }

    //INSERTS datafields into Database Table
    protected void SubButton_Click(object sender, EventArgs e)
    {
        Call_Database callDB = new Call_Database();

        if (ImageUpload.HasFile)
        {
            if (CheckFileType(ImageUpload.FileName))
            {
                string strPath = "../Images/dbImages/" + ImageUpload.FileName;

                ImageUpload.SaveAs(MapPath(strPath));
            }
        }
        if (NameBox.Text != "" && txtProfile.Text != "")
        {
            string Action = "DonorsINSERT";
            callDB.FormINSERT(Action, NameBox.Text, ImageUpload.FileName, txtProfile.Text, null, null, 0, 0, 0, 0);

            NameBox.Text = String.Empty;
            txtProfile.Text = String.Empty;
            Call_Database update = new Call_Database();
            RepeaterNum.DataSource = update.dbDonors;
            RepeaterNum.DataBind();
        }
    }

    //Update Video
    protected void VidChange_Click(object sender, EventArgs e)
    {
        Call_Database vidDB = new Call_Database();

        vidDB.VideoUPDATE(VidBox.Text);
        VidBox.Text = String.Empty;
    }

    //DELETE datafields from Database Table
    protected void DeleteLink_Click(object sender, EventArgs e)
    {
        Call_Database deleteEntry = new Call_Database();
        string Action = "DonorsDELETE";
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
        deleteEntry.Delete(deleteId, Action);
        Call_Database update = new Call_Database();
        RepeaterNum.DataSource = update.dbDonors;
        RepeaterNum.DataBind();
    }

    //CONTROL Buttons for Repeater
    protected void OnEdit_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements(item, true);
    }
    protected void OnEditAlumni_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements2(item, true);
    }
    protected void OnCancel_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements(item, false);
    }
    protected void OnCancelAlumni_Click(object sender, EventArgs e)
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
        item.FindControl("photoLabel").Visible = !isEdit;
        item.FindControl("nameLabel").Visible = !isEdit;
        item.FindControl("profileLabel").Visible = !isEdit;

        //Toggle TextBoxes.
        item.FindControl("EditPhoto").Visible = isEdit;
        item.FindControl("EditName").Visible = isEdit;
        item.FindControl("EditProfile").Visible = isEdit;
        item.FindControl("EditAlumniName").Visible = isEdit;
        item.FindControl("EditAlumni").Visible = isEdit;


    }

    private void ToggleElements2(RepeaterItem item, bool isEdit)
    {
        //Toggle Buttons.
        item.FindControl("editLink").Visible = !isEdit;
        item.FindControl("updateLink").Visible = isEdit;
        item.FindControl("cancelLink").Visible = isEdit;

        //Toggle Labels.
        item.FindControl("AlumniNameLabel").Visible = !isEdit;
        item.FindControl("AlumniLabel").Visible = !isEdit;

        //Toggle TextBoxes.
        item.FindControl("EditAlumniName").Visible = isEdit;
        item.FindControl("EditAlumni").Visible = isEdit;


    }

    //UPDATE datafields from Repeater Table
    protected void OnUpdate_Click(object sender, EventArgs e)
    {
        Call_Database updateEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        string Action = "DonorsUPDATE";
        int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
        string EditName = (item.FindControl("EditName") as TextBox).Text;
        string EditPhoto = (item.FindControl("EditPhoto") as TextBox).Text;
        string EditProfile = (item.FindControl("EditProfile") as TextBox).Text;
        updateEntry.FormUPDATE(Action, EditName, EditPhoto, EditProfile, null, null, updateId, 0, 0, 0);
        Call_Database update = new Call_Database();
        RepeaterNum.DataSource = update.dbDonors;
        RepeaterNum.DataBind();
    }

    protected void OnAlumniUpdate_Click(object sender, EventArgs e)
    {
        Call_Database updateEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        string Action = "AlumniMapUPDATE";
        int updateId = int.Parse((item.FindControl("idLabel") as Label).Text);
        string EditName = (item.FindControl("EditAlumniName") as TextBox).Text;
        string EditAlumni = ((item.FindControl("EditAlumni") as TextBox).Text);
        int EditAlumniNum = Convert.ToInt32(EditAlumni);
        updateEntry.FormUPDATE(Action, EditName, null, null, null, null, updateId, EditAlumniNum, 0, 0);
        Call_Database update = new Call_Database();
        RepeaterNum2.DataSource = update.dbAlumniMap;
        RepeaterNum2.DataBind();
        }
}