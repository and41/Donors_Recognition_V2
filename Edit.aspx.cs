using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strQuery = "";
        if (Request.QueryString["id"] != null)
        {
            strQuery = Request.QueryString["id"].ToString();
        }




        Call_Database classDBDonors = new Call_Database();
        Repeater2.DataSource = classDBDonors.dbDonors;
        Repeater2.DataBind();
    }

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

    protected void SubButton_Click(object sender, EventArgs e)
    {
        Call_Database callDbDonors = new Call_Database();

        if (ImageUpload.HasFile)
        {
            if (CheckFileType(ImageUpload.FileName))
            {
                string strPath = "Images/dbImages/" + ImageUpload.FileName;

                ImageUpload.SaveAs(MapPath(strPath));

            }
        }
        if (NameBox.Text != "" && txtProfile.Text != "")
        {

            callDbDonors.Add(NameBox.Text, ImageUpload.FileName, txtProfile.Text);

            NameBox.Text = String.Empty;
            txtProfile.Text = String.Empty;
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        Call_Database deleteEntry = new Call_Database();
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        int deleteId = int.Parse((item.FindControl("idLabel") as Label).Text);
        deleteEntry.Delete(deleteId);
        Response.Redirect(Request.RawUrl);
    }
    /*Finish Edit/Update Functions and put into Call_Database class: Also rember to reAdd OnClick="Edit_Click"
    /*
    protected void Edit_Click(object sender, EventArgs e)
    {
        //Find the reference of the Repeater Item.
        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        this.ToggleElements(item, true);
    }

    private void ToggleElements(RepeaterItem item, bool isEdit)
    {
        //Toggle Labels.
        item.FindControl("photoLabel").Visible = isEdit;
        item.FindControl("nameLabel").Visible = isEdit;
        item.FindControl("profileLabel").Visible = isEdit;
    }
    */
}