<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestimonialManagement.aspx.cs" Inherits="ContentPages_TestimonialManagement" %>

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
    <div style="height: 880px; background-color: gainsboro;">
        </br>
        <h2>Donors Table (Id | Name | Profile | PhotoUrl)</h2>
        </br>
        <asp:Repeater ID="RepeaterNum" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="nameLabel" Text='<%# Eval("name") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Width="350" Text='<%# Eval("name") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="profileLabel" CssClass="profileCSS" Text='<%# Eval("profile") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditProfile" runat="server" Text='<%# Eval("profile") %>' Width="550" Height="70" TextMode="multiLine" Visible="false" />
                </td>
                <td><asp:Label ID="photoLabel" Text='<%# Eval("photo") %>' runat="server" Width="450"></asp:Label>
                     <asp:TextBox ID="EditPhoto" runat="server" Width="350" Text='<%# Eval("photo") %>' Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        <div id="SubmitDiv">
        </br>
        <h2>Donor Submit Form</h2>
        </br>
        <p>
            <asp:Label ID="LName_Form" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LPhoto_Form" runat="server" Text="Photo"></asp:Label>
            :
            <asp:FileUpload ID="ImageUpload" runat="server" Height="33px" Width="320px" />
        </p>
        <p>
            <asp:Label ID="LProfile_Form" runat="server" Text="Profile"></asp:Label>
            :
            <asp:TextBox ID="txtProfile" runat="server" Width="320px" Height="92px" TextMode="multiLine"></asp:TextBox>
        </p>
            <p>
                <asp:Button ID="SubButton" runat="server" OnClick="SubButton_Click" Text="Submit" />
            </p>
        </div>
    </div>
    </form>
    <footer>
        <div>
            </br>
        </div>
    </footer>
</body>
</html>
