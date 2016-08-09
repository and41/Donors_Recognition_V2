<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Leadership.aspx.cs" Inherits="Leadership" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leadership</title>
    <link href="~/css/Leadership.css" rel="stylesheet" type="text/css" />
    <link href="~/css/LeadershipFund.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Javascript/Leadership_JS/Leadership.js"></script>
</head>
<body onload="openCity(event, 'AdvBoard')">
<div class="leaderdiv">
    <ul class="tab">
  <li><a href="#" class="tablinks" onclick="openCity(event, 'AdvBoard')">Advisory Board</a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'ElecBoard')">Pitt Bradford Alumni Association Elected Members</a></li>
    </ul>

  <form id="form1" runat="server">
      <div id="AdvBoard" class="tabcontent">
    <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                <p>Advisory Board Members in all 4 Categories</p>
                </br>
            </div>
            </div>
            <table id="viewTable""></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="AdvName" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="AdvStatus" Text='<%# Eval("Status") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
      <div id="ElecBoard" class="tabcontent">
    <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate><div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                <p>PBAA Elected Board Members</p>
                </br>
            </div>
            </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div class="tabletest">
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="ElecName" style="padding: 0px 260px 0px 274px;" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
</div>
        </form>
</div>
    <footer>
        <div class="footer">
        <div class="footer-div">
        <a href="Default.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label">Home</p>
        </div></a>
        <a href="Recognition_Home.aspx"><div class="menubar two">
            <img src="Images/Home_Assets/Icons/Rec_Icon.png" alt="" class="icon" />
            <p class="label">Recognition</p>
        </div></a>
        <a href="History.aspx"><div class="menubar three">
            <img src="Images/Home_Assets/Icons/History_Icon.png" alt="" class="icon" />
            <p class="label">History</p>
        </div></a>
        <a href="Donor_Testimonials.aspx"><div class="menubar four">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
            <p class="label">Testimonials</p>
        </div></a>
        <a href="Leadership.aspx"><div class="menubar five">
            <img src="Images/Home_Assets/Icons/Leadership_Icon.png" alt="" class="icon" />
            <p class="label">Leadership</p>
        </div></a>
        <a href="Events.aspx"><div class="menubar six">
            <img src="Images/Home_Assets/Icons/Event_Icon.png" alt="" class="icon" />
            <p class="label">Events</p>
        </div></a>
        <a href="Donor_Map.aspx"><div class="menubar seven">
            <img src="Images/Home_Assets/Icons/Map_Icon.png" alt="" class="icon" />
            <p class="label">Donor Map</p>
        </div></a>
        <a href="Alumni_Map.aspx"><div class="menubar eight">
            <img src="Images/Home_Assets/Icons/Alum_Icon.png" alt="" class="icon" />
            <p class="label">Alumni Map</p>
        </div></a>
        </div>
        </div>
    </footer>
</body>
</html>
