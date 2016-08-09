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
  <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Honor Roll of Donors</a></li>
    </ul>

  <form id="form1" runat="server">
      <div id="Scholarships" class="tabcontent">
          <asp:Repeater ID="Repeater3" runat="server">
            <HeaderTemplate><div class="template"><table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="ScholarTd"><asp:Label ID="SortScholar" Text='<%# Eval("Sort") %>' runat="server"></asp:Label></td>
                <td class="ScholarTd2"><asp:Label ID="NameScholar" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                <td class="ScholarTd"><asp:Label ID="EstablishedScholar" Text='<%# Eval("Established") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
      <div id="FounderSoc" class="tabcontent">
          <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><div class="template">
                <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Since its founding in 1963, the University of Pittsburgh at Bradford has been fortunate to receive the support of many
                   generous individuals, organizations and community leaders in seeing a vision become a reality.  With each successful addition
                   to the campus and its curriculum, there have been supporters who helped initiate and carry forward ideas through planning and philanthropy.
                </p>
                </br>
                <p>Pitt-Bradford has established the Founders' Society to recognize alumni, faculty, staff and friends who have made a commitment
                   to the college through a planned gift to the Bradford Educational Foundation.  In making these gifts, Founders' Society members
                   are ensuring that Pitt-Bradford will have the financial resources to provide educational opportunities well into the future.
                </p>
                </br>
                <p>Planned gifts -- gifts made through wills, life insurance, trusts and other programs -- have become an increasingly important source of Pitt-Bradford's strength and growth.
                   These resources provide for scholarships, academic program expansion and campus development as well as unrestricted funds.
                </p>
                </br>
                <p>All planned gifts, regardless of size, enroll the donor in the Founders' Society.</p>
                </br>
                </div>
                </div>
                <table id="viewTable"></HeaderTemplate>
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
               <iframe width="1070" height="610" src="https://www.youtube.com/embed/4ol5j-kepuI" frameborder="0" allowfullscreen></iframe>
</div>
           <div id="CornerstoneTab" class="tabcontent">
               <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate>
                <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>
                <div class="template">
                <div style="background: #E8E8E8;">
                    <div style="font-size: 20px;">
                    </br>
                    <p>Annual Giving Fund and capital gift donors of $5,000 or more in 2014-2015
                    </p>
                    </br>
                    <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                    </p>
                    </br>
                    <p>*deceased
                    </p>
                    </br>
                    </div>
                    </div>
                <table id="viewTable">
                </HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="CornerstoneName"><asp:Label ID="CornerstoneName" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
</div>
      <!-- This is for the Donor Honor Roll's Subtabs, covers All Societies -->
      <div id="RoundtableTab" class="tabcontent">
          <asp:Repeater ID="Repeater4" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors of $2,500 to $4,999 in 2014-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="RoundtableTdCSS"><asp:Label ID="RoundtableTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="PresidentsTab" class="tabcontent">
          <asp:Repeater ID="Repeater5" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors of $1,000 to $2,499 in 2014-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="PrimaryTdCSS"><asp:Label ID="PrimaryTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="QuadrangleTab" class="tabcontent">
          <asp:Repeater ID="Repeater6" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors of $500 to $999 in 2014-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="PrimaryTdCSS"><asp:Label ID="PrimaryTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="BlueGoldTab" class="tabcontent">
          <asp:Repeater ID="Repeater7" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors of $300 to $499 in 2014-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="SecondaryTdCSS"><asp:Label ID="SecondaryTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="CenturyTab" class="tabcontent">
          <asp:Repeater ID="Repeater8" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors of $100 to $299 in 2015-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="CenturyTdCSS"><asp:Label ID="CenturyTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></div></FooterTemplate>
        </asp:Repeater>
    </div>
    <div id="OtherDonorsTab" class="tabcontent">
          <asp:Repeater ID="Repeater9" runat="server">
            <HeaderTemplate>
            <div class="subdiv">
                <ul class="subtab">
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a></li>
                   <li><a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a></li>
                </ul>
                </div>    
            <div class="template">
            <div style="background: #E8E8E8;">
                <div style="font-size: 20px;">
                </br>
                <p>Annual Giving Fund and capital gift donors up to $100 in 2014-2015
                </p>
                </br>
                <p>Year of graduation or years attended are listed after Pitt-Bradford alumni names. 
                   Numbers in parentheses indicate consecutive years of giving since July 1, 1989.  Donors reaching 5, 10, 15, 20, or 25 consecutive years
                   of giving are highlighted in bold.  
                </p>
                </br>
                <p>*deceased
                </p>
                </br>
                </div>
                </div>
            <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="OtherDonorTdCSS"><asp:Label ID="OtherDonorTdCSS" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
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
