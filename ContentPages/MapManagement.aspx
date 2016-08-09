<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MapManagement.aspx.cs" Inherits="ContentPages_MapManagement" %>

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
            <asp:Button ID="MapGOTO" runat="server" Text="Go To" OnClick="GOTO_Click" /></li></ul>
    <div style="height: 880px; background-color: gainsboro;">
        <div id="OutdoorsTableShow" runat="server" visible="false">
        </br>
        <h2>Outdoors Table (Id | Location | Name | Area | Plaque | Dedication)</h2>
        </br>
        <asp:Repeater ID="RepeaterNum1" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="locationLabel" Text='<%# Eval("Location") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditLocation" runat="server" Width="350" Text='<%# Eval("Location") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="nameLabel" CssClass="profileCSS" Text='<%# Eval("[Donor Name]") %>' runat="server" Width="300"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Text='<%# Eval("[Donor Name]") %>' Width="300" Visible="false" />
                </td>
                <td><asp:Label ID="areaLabel" CssClass="profileCSS" Text='<%# Eval("[Name of Area]") %>' runat="server" Width="250"></asp:Label>
                    <asp:TextBox ID="EditArea" runat="server" Text='<%# Eval("[Name of Area]") %>' Width="250" Visible="false" />
                </td>
                <td><asp:Label ID="plaqueLabel" CssClass="profileCSS" Text='<%# Eval("[Wording on Plaque]") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditPlaque" runat="server" Text='<%# Eval("[Wording on Plaque]") %>' Width="550" Visible="false" />
                </td>
                <td><asp:Label ID="dedicationLabel" CssClass="profileCSS" Text='<%# Eval("[Dedication Date]") %>' runat="server" Width="250"></asp:Label>
                    <asp:TextBox ID="EditDedication" runat="server" Text='<%# Eval("[Dedication Date]") %>' Width="250" Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
        <div id="ChapelTableShow" runat="server" visible="false">
        </br>
        <h2>Chapel Table (Id | Level | Plaque | Sort | ViewOrder )</h2>
        </br>
        <asp:Repeater ID="RepeaterNum2" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="levelLabel" Text='<%# Eval("Level") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditLevel" runat="server" Width="350" Text='<%# Eval("Level") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="plaqueLabel" CssClass="profileCSS" Text='<%# Eval("Plaque") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditPlaque" runat="server" Text='<%# Eval("Plaque") %>' Width="550" Visible="false" />
                </td>
                <td><asp:Label ID="sortLabel" CssClass="profileCSS" Text='<%# Eval("Sort") %>' runat="server" Width="200"></asp:Label>
                    <asp:TextBox ID="EditSort" runat="server" Text='<%# Eval("Sort") %>' Width="200" Visible="false" />
                </td>
                <td><asp:Label ID="orderLabel" CssClass="profileCSS" Text='<%# Eval("ViewOrder") %>' runat="server" Width="50"></asp:Label>
                    <asp:TextBox ID="EditOrder" runat="server" Text='<%# Eval("ViewOrder") %>' Width="50" Visible="false" />
                </td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="DeleteLink_Click" OnClientClick="return confirm('Do you want to delete this row?');"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" OnClick="OnEdit_Click" runat="server"></asp:LinkButton><asp:LinkButton ID ="updateLink" CssClass="LinkPad" Text="Update" OnClick="OnUpdate_Click" runat="server" Visible="false"></asp:LinkButton><asp:LinkButton ID ="cancelLink" Text="Cancel" OnClick="OnCancel_Click" runat="server" Visible="false"></asp:LinkButton></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
        <div id="MapTableShow" runat="server" visible="false">
        </br>
        <h2>Map Tables (Id | RoomId | Name | Plaque | Date )</h2>
        </br>
        <asp:Repeater ID="RepeaterNum3" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="roomidLabel" Text='<%# Eval("RoomId") %>' runat="server" Width="350"></asp:Label>
                    <asp:TextBox ID="EditRoomId" runat="server" Width="350" Text='<%# Eval("RoomId") %>'  Visible="false" />
                </td>
                <td><asp:Label ID="nameLabel" CssClass="profileCSS" Text='<%# Eval("RoomName") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditName" runat="server" Text='<%# Eval("RoomName") %>' Width="550" Visible="false" />
                </td>
                <td><asp:Label ID="plaqueLabel" CssClass="profileCSS" Text='<%# Eval("RoomPlaque") %>' runat="server" Width="550"></asp:Label>
                    <asp:TextBox ID="EditPlaque" runat="server" Text='<%# Eval("RoomPlaque") %>' Width="550" Visible="false" />
                </td>
                <td><asp:Label ID="dateLabel" CssClass="profileCSS" Text='<%# Eval("Date") %>' runat="server" Width="200"></asp:Label>
                    <asp:TextBox ID="EditDate" runat="server" Text='<%# Eval("Date") %>' Width="200" Visible="false" />
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
        <h2>Map Submit Form</h2>
        </br>
        <p id="LocationShow" runat="server" visible="false">
            <asp:Label ID="LLocation_Form" runat="server" Text="Location"></asp:Label>
            :
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        </p>
        <p id="RoomIdShow" runat="server" visible="false">
            <asp:Label ID="LRoomId_Form" runat="server" Text="Location"></asp:Label>
            :
            <asp:TextBox ID="txtRoomId" runat="server"></asp:TextBox>
        </p>
        <p id="LevelShow" runat="server" visible="false">
            <asp:Label ID="LLevel_Form" runat="server" Text="Level"></asp:Label>
            :
            <asp:TextBox ID="txtLevel" runat="server"></asp:TextBox>
        </p>
        <p id="NameShow" runat="server" visible="false">
            <asp:Label ID="LName_Form" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p id="SortShow" runat="server" visible="false">
            <asp:Label ID="LSort_Form" runat="server" Text="Sort"></asp:Label>
            :
            <asp:TextBox ID="txtSort" runat="server"></asp:TextBox>
        </p>
        <p id="AreaShow" runat="server" visible="false">
            <asp:Label ID="LArea_Form" runat="server" Text="Area"></asp:Label>
            :
            <asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
        </p>
        <p id="PlaqueShow" runat="server" visible="false">
            <asp:Label ID="LPlaque_Form" runat="server" Text="Plaque" ></asp:Label>
            :
            <asp:TextBox ID="txtPlaque" runat="server" Width="320px" Height="92px" TextMode="multiLine"></asp:TextBox>
        </p>
        <p id="DateShow" runat="server" visible="false">
            <asp:Label ID="LDate_Form" runat="server" Text="Date"></asp:Label>
            :
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <p id="OrderShow" runat="server" visible="false">
            <asp:Label ID="LOrder_Form" runat="server" Text="ViewOrder"></asp:Label>
            :
            <asp:TextBox ID="txtOrder" runat="server"></asp:TextBox>
        </p>
        <p id="DedicationShow" runat="server" visible="false">
            <asp:Label ID="LDedication_Form" runat="server" Text="Dedication"></asp:Label>
            :
            <asp:TextBox ID="txtDedication" runat="server"></asp:TextBox>
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
