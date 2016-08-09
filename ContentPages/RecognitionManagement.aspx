<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecognitionManagement.aspx.cs" Inherits="ContentPages_RecognitionManagement" %>

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
            <asp:Button ID="RecognitionGOTO" runat="server" Text="Go To" OnClick="GOTO_Click" /></li></ul>
    <div style="height: 880px; background-color: gainsboro;">
        <div id="ScholarshipsTableShow" runat="server" visible="false">
        </br>
        <h2>Scholarships Table (Id | Sort | Name | Established)</h2>
        </br>
        <asp:Repeater ID="RepeaterNum1" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="sortLabel" Text='<%# Eval("Sort") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditSort" runat="server" Width="350" Text='<%# Eval("Sort") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="nameLabel" CssClass="profileCSS" Text='<%# Eval("Name") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Text='<%# Eval("Name") %>' Width="550" Visible="false" />
                </td>
                <td><asp:Label ID="establishedLabel" CssClass="profileCSS" Text='<%# Eval("Established") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditEstablished" runat="server" Text='<%# Eval("Established") %>' Width="550" Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
        <div id="FoundersTableShow" runat="server" visible="false">
        </br>
        <h2>Founders Table (Id | Name | Status)</h2>
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
        <div id="SocietyTableShow" runat="server" visible="false">
        </br>
        <h2>Society Table (Id | Name)</h2>
        </br>
            <asp:Repeater ID="RepeaterNum3" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="nameLabel" Text='<%# Eval("Name") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Width="350" Text='<%# Eval("Name") %>'  Visible="false" />
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
        <h2>Recognition Submit Form</h2>
        </br>
        <p>
            <asp:Label ID="LName_Form" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p id="SortShow" runat="server" visible="false">
            <asp:Label ID="LSort_Form" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="txtSort" runat="server"></asp:TextBox>
        </p>
        <p id="StatusShow" runat="server" visible="false">
            <asp:Label ID="LStatus_Form" runat="server" Text="Status"></asp:Label>
            :
            <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        </p>
        <p id="EstablishedShow" runat="server" visible="false">
            <asp:Label ID="LEstablished_Form" runat="server" Text="Established"></asp:Label>
            :
            <asp:TextBox ID="txtEstablished" runat="server"></asp:TextBox>
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
