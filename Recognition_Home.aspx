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

<div id="mySidenav" class="sidenav">
  <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
  <a href="#" class="tablinks" onclick="openCity(event, 'Scholarships')">Scholarships</a>
  <a href="#" class="tablinks" onclick="openCity(event, 'FounderSoc')">Founder's Society</a>
  <a href="#" class="tablinks" onclick="openCity(event, 'Campaign50')">Campaign 50 Donors</a>
  <a href="#" class="tablinks" onclick="openSecNav(), openCity(event, 'CornerstoneTab')"">Honor Roll of Donors</a>
</div>

<div id="mySecSidenav" class="sidenav">
  <a href="javascript:void(0)" class="closebtn" onclick="closeSecNav()">&larr;</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'CornerstoneTab')">Cornerstone Society</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'RoundtableTab')">Roundtable Society</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'PresidentsTab')">President's Society</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'QuadrangleTab')">Quadrangle Club</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'BlueGoldTab')">Blue & Gold</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'CenturyTab')">Century Club</a>
        <a href="#" class="tablinks" onclick="openCity(event, 'OtherDonorsTab')">Other Donors</a>
</div>

<span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; Menu</span>

  <div class="leaderdiv">

  <form id="form1" runat="server" style="border-radius: 10px; border: 3px solid #cdb87d; margin-right: 428px;">
      <div id="Scholarships" class="tabcontent">
          <asp:Repeater ID="Repeater3" runat="server">
            <HeaderTemplate><div class="template">
                <div style="background: #cdb87d">
                <div style="font-size: 20px;">
                </br>
                <h2 style="padding: 10px;"><center>Scholarships</center></h2>
                </div>
                </div>
                <table id="viewTable"></HeaderTemplate>
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
                <div style="background: #cdb87d">
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
                <p>*Deceased</p>
                </div>
                </div>
                <table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td class="FounderName" style="width: 100%;"><asp:Label ID="FounderName" Text='<%# Eval("Name") %>' runat="server"></asp:Label></td>
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
                <div class="template">
                <div style="background: #cdb87d">
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
                
            <div class="template">
            <div style="background: #cdb87d">
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
                
            <div class="template">
            <div style="background: #cdb87d">
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
               
            <div class="template">
            <div style="background: #cdb87d">
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
               
            <div class="template">
            <div style="background: #cdb87d">
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
                
            <div class="template">
            <div style="background: #cdb87d">
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
               
            <div class="template">
            <div style="background: #cdb87d">
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

    <script>
        /* Set the width of the side navigation to 250px */
        function openNav() {
            document.getElementById("mySidenav").style.width = "250px";
        }

        /* Set the width of the side navigation to 0 */
        function closeNav() {
            document.getElementById("mySidenav").style.width = "0";
        }

        function openSecNav() {
            document.getElementById("mySecSidenav").style.width = "250px";
            document.getElementById("mySidenav").style.width = "0";
        }

        /* Set the width of the side navigation to 0 */
        function closeSecNav() {
            document.getElementById("mySecSidenav").style.width = "0";
            document.getElementById("mySidenav").style.width = "250px";
        }
    </script>

   <footer>
        <div class="footer">
        <div class="footer-div">
        <a href="Default.aspx"><div class="menubar">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label"></p>
        </div></a>
        </div>
        </div>
    </footer>
</body>
</html>
