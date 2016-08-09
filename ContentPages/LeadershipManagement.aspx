<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LeadershipManagement.aspx.cs" Inherits="ContentPages_LeadershipManagement" %>

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
        <ul class="tab" runat="server">
        <li><asp:DropDownList ID="LeadershipDisplay" runat="server">
                <asp:ListItem Value="AdvBoard">Advisory Board</asp:ListItem>
                <asp:ListItem Value="ElecBoard">PBAA Elected Board</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="LeadershipGOTO" runat="server" Text="Go To" OnClick="GOTO_Click" /></li></ul>
    <div style="height: 880px; background-color: gainsboro;">
        <div id="AdvBoardTableShow" runat="server" visible="false">
        </br>
        <h2>AdvBoard Table (Id | Name | Status)</h2>
        </br>
        <asp:Repeater ID="RepeaterNum1" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="nameLabel" Text='<%# Eval("Name") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Width="350" Text='<%# Eval("Name") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="statusLabel" CssClass="profileCSS" Text='<%# Eval("Status") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditStatus" runat="server" Text='<%# Eval("Status") %>' Width="550" Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
        <div id="ElecBoardTableShow" runat="server" visible="false">
        </br>
        <h2>ElecBoard Table (Id | Name | Year)</h2>
        </br>
        <asp:Repeater ID="RepeaterNum2" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="nameLabel" Text='<%# Eval("Name") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Width="350" Text='<%# Eval("Name") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="yearLabel" CssClass="profileCSS" Text='<%# Eval("Year") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditYear" runat="server" Text='<%# Eval("Year") %>' Width="550" Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
        <div id="SubmitDiv" runat="server" visible="false">
        </br>
        <h2>Leadership Submit Form</h2>
        </br>
        <p>
            <asp:Label ID="LName_Form" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p id="StatusShow" runat="server" visible="false">
            <asp:Label ID="LStatus_Form" runat="server" Text="Status"></asp:Label>
            :
            <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        </p>
        <p id="YearShow" runat="server" visible="false">
            <asp:Label ID="LYear_Form" runat="server" Text="Year"></asp:Label>
            :
            <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
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
