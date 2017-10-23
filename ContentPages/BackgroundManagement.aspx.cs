using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class ContentPages_BackgroundManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected bool CheckFileType(string strFileName)
    {

        string strExt = System.IO.Path.GetExtension(strFileName).ToLower();
        bool isGraphic = false;

        switch (strExt)
        {
            case ".bmp":
                isGraphic = false;
                break;
            case ".jpg":
                isGraphic = true;
                break;
            case ".gif":
                isGraphic = false;
                break;
            case ".jpeg":
                isGraphic = false;
                break;
            case ".png":
                isGraphic = false;
                break;
            default:
                isGraphic = false;
                break;
        }
        return isGraphic;
    }

    protected void SubButton_Click(object sender, EventArgs e)
    {
        if (ImageUpload.HasFile)
        {
            StatusLabel.Text = "Loading";
            if(CheckFileType(ImageUpload.FileName))
            {
                        if (BackgroundSelect.Items.FindByValue("Home_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "DefaultBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("Events_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "EventsBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("Gallery_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "GalleryBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("History_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "HistoryBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("Leadership_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "LeadershipBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("Recognition_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "RecognitionBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }

                        else if (BackgroundSelect.Items.FindByValue("Testimonials_Page").Selected == true)
                        {
                        string strPath = "../Images/Background_Assets/" + "TestimonialsBackground.jpg";

                        ImageUpload.SaveAs(MapPath(strPath));
                        }
                StatusLabel.Text = "Uploaded";
            }
            }
        }
    }