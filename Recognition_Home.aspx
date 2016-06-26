<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Recognition_Home.aspx.cs" Inherits="Donors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recognition</title>
    <link href="~/css/Recognition.css" rel="stylesheet" type="text/css" />
    <link href="~/css/RecognitionDB.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Javascript/Leadership_JS/Leadership.js"></script>
</head>
<body onload="openCity(event, 'Scholarships')">
    <div class="leaderdiv">
    <ul class="tab">
  <li><a href="#" class="tablinks" onclick="openCity(event, 'Scholarships')">Scholarships</a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'FounderSoc')">Founder's Society</a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'Campaign50')">Campaign 50 Donors</a></li>
  <li><a href="#" class="tablinks" onclick="openCity(event, 'HonorRoll')">Honor Roll of Donors</a></li>
    </ul>

  <form id="form1" runat="server">
      <div id="Scholarships" class="tabcontent">
          <asp:Repeater ID="Repeater3" runat="server">
            <HeaderTemplate><div class="template"><table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="SortScholar" Text='<%# Eval("Sort") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="NameScholar" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="EstablishedScholar" Text='<%# Eval("Established") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
      <div id="FounderSoc" class="tabcontent">
          <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><div class="template"><table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="FounderName"><asp:Label ID="FounderName" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                <td class="FounderStatus"><asp:Label ID="FounderStatus" Text='<%# Eval("Status") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
</div>
           <div id="Campaign50" class="tabcontent">
               <iframe width="1077px" height="610px" src="https://www.youtube.com/embed/4ol5j-kepuI" frameborder="0" allowfullscreen></iframe>
</div>
           <div id="HonorRoll" class="tabcontent">
               <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate><div class="template"><table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="HonorName"><asp:Label ID="NameHonor" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                <td class="HonorYear"><asp:Label ID="YearsHonor" Text='<%# Eval("Years") %>' runat="server"></asp:Label></td>
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
        <a href="Recognition_Home.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label">Recognition</p>
        </div></a>
        <a href="History.aspx"><div class="menubar two">
            <img src="Images/Home_Assets/Icons/History_Icon.png" alt="" class="icon" />
            <p class="label">History</p>
        </div></a>
        <a href="Donor_Testimonials.aspx"><div class="menubar three">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
            <p class="label">Testimonials</p>
        </div></a>
        <a href="Leadership.aspx"><div class="menubar four">
            <img src="Images/Home_Assets/Icons/Leadership_Icon.png" alt="" class="icon" />
            <p class="label">Leadership</p>
        </div></a>
        <a href="Events.aspx"><div class="menubar five">
            <img src="Images/Home_Assets/Icons/Event_Icon.png" alt="" class="icon" />
            <p class="label">Events</p>
        </div></a>
        <a href="Donor_Map.aspx"><div class="menubar six">
            <img src="Images/Home_Assets/Icons/Map_Icon.png" alt="" class="icon" />
            <p class="label">Donor Map</p>
        </div></a>
        <a href="Alumni_Map.aspx"><div class="menubar seven">
            <img src="Images/Home_Assets/Icons/Map_Icon.png" alt="" class="icon" />
            <p class="label">Alumni Map</p>
        </div></a>
        </div>
    </footer>
</body>
</html>
