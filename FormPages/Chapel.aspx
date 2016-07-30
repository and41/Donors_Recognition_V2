<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chapel.aspx.cs" Inherits="FormPages_Chapel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/Donor_MapForms.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/jquery-ui.css"/>
    <link href="../css/Chapel.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="../Javascript/Popup_JS/jquery.popupoverlay.js"></script>
    <script type="text/javascript" src="../Javascript/Leadership_JS/Leadership.js"></script>
</head>
<body onload="openCity(event, 'ChapelBuildings')">
    <div class="FormWrap">
    <div class="Formdiv">
    <div class="FormTitle">
    <h2 id="ChapelTitle">Harriett B. Wick Chapel</h2>
    </div>
    </br>
    <b><p>Named in honor of Harriett B. Wick for her tremendous dedication to Pitt- Bradford, its students, and the Bradford community.
    </br>
    </br>
    Harriett and the Philo and Sarah Blaisdell Foundation, Zippo Manufacturing and W.R. </p></b>
    </br>
    </div>

    <ul class="tab">
  <li><a href="#" class="tablinks" onclick="openCity(event, 'ChapelBuildings')"><h2>ChapelBuildings</h2></a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'ChairsBenches')"><h2>Chairs & Benches</h2></a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'DonorsWall')"><h2>Chapel Donor's Wall</h2></a></li>
    </ul>
    <form id="form1" runat="server">
        <div id="ChapelBuildings" class="tabcontent">
    <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
            <table id="BuildingsTable" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Level") %>' runat="server"></asp:Label></td>
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
      <div id="DonorsWall" class="tabcontent">
    <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate>
            <table id="HarmonyWall" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    <asp:Repeater ID="Repeater3" runat="server">
            <HeaderTemplate>
            <table id="HopeWall" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    <asp:Repeater ID="Repeater4" runat="server">
            <HeaderTemplate>
            <table id="FaithWall" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    <asp:Repeater ID="Repeater5" runat="server">
            <HeaderTemplate>
            <table id="HopeWall" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    <asp:Repeater ID="Repeater6" runat="server">
            <HeaderTemplate>
            <table id="PeaceWall" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="ChairsBenches" class="tabcontent">
    <asp:Repeater ID="Repeater7" runat="server">
            <HeaderTemplate>
            <table id="ChairsTable" class="ChapelWall"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Plaque") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
    </div>
</body>
</html>
