<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadDrop.aspx.cs" Inherits="ContentPages_UploadDrop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 62px;
            width: 311px;
        }
        .LinkPad{
            padding-right: 5px;
        }
    </style>
    <link href="../css/Content_Management.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul class="tab" runat="server">
        <li>
            <%--Master Dropdown--%>
            <asp:DropDownList ID="TablesDisplay" runat="server">
                <asp:ListItem Value="LeadershipTables">Leadership Tables</asp:ListItem>
                <asp:ListItem Value="MapTables">Map Tables</asp:ListItem>
                <asp:ListItem Value="RecTables">Recognition Tables</asp:ListItem>
                <asp:ListItem Value="TestimonialTables">Testimonial Tables</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="DropdownGOTO" runat="server" Text="Go To" onclick="GOTO_Click"/>
            </br>
        </li>
        <li>
            <%--Leadership Upload Select--%>
            <asp:DropDownList ID="LeadershipUpload" runat="server" Visible="false">
                <asp:ListItem Value="AdvBoard">Advisory Board</asp:ListItem>
                <asp:ListItem Value="ElecBoard">PBAA Elected Board</asp:ListItem>
            </asp:DropDownList>
            <%--Recognition Upload Select--%>
            <asp:DropDownList ID="RecognitionUpload" runat="server" Visible="false">
                <asp:ListItem Value="Scholarships">Scholarships</asp:ListItem>
                <asp:ListItem Value="Founders">Founder's Society</asp:ListItem>
                <asp:ListItem Value="CornerstoneTab">Cornerstone Society</asp:ListItem>
                <asp:ListItem Value="RoundtableTab">Roundtable Society</asp:ListItem>
                <asp:ListItem Value="PresidentsTab">President's Society</asp:ListItem>
                <asp:ListItem Value="QuadrangleTab">Quadrangle Club</asp:ListItem>
                <asp:ListItem Value="BlueGoldTab">Blue & Gold Club</asp:ListItem>
                <asp:ListItem Value="CenturyTab">Century Club</asp:ListItem>
                <asp:ListItem Value="OtherDonorsTab">Other Donors</asp:ListItem>
            </asp:DropDownList>
            <%--Map Upload Select--%>
            <asp:DropDownList ID="MapDataUpload" runat="server" Visible="false">
                <asp:ListItem Value="OutdoorsInfo">Outdoors Table</asp:ListItem>
                <asp:ListItem Value="ChapelInfo">Chapel Table</asp:ListItem>
                <asp:ListItem Value="CommonsInfo">Commons Table</asp:ListItem>
                <asp:ListItem Value="FisherHallInfo">Fisher Hall Table</asp:ListItem>
                <asp:ListItem Value="FitnessCenterInfo">Fitness Center Table</asp:ListItem>
                <asp:ListItem Value="LibraryInfo">Hanley Library Table</asp:ListItem>
                <asp:ListItem Value="ResHallInfo">Residential Hall</asp:ListItem>
                <asp:ListItem Value="SwartsHallInfo">Swarts Hall</asp:ListItem>
                <asp:ListItem Value="BlaisdellHallInfo">Blaisdell Hall</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="SelectUpload" runat="server" Text="Select" visible="false" OnClick="UPLOADSelect_Click" />
            </br>
        </li>
        <li>
            <div id="UploadDiv" runat="server" visible="false">
            <asp:FileUpload ID="FileUploadID" runat="server" />
            <asp:Button ID="UploadButtonID" runat="server" Text="Upload" OnClick="UPLOADData_Click" />
            </br>
            </div>
        </li>
    </ul>


    </div>
    </form>
</body>
</html>
