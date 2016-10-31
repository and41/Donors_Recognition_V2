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

    <div id="mySidenav" class="sidenav">
  <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
  <a href="#" class="tablinks" onclick="openCity(event, 'AdvBoard')">Advisory Board</a>
  <a href="#" class="tablinks" onclick="openCity(event, 'ElecBoard')">Pitt Bradford Alumni Association Elected Members</a>
</div>

<span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; Menu</span>



<div class="leaderdiv">

  <form id="form1" runat="server" style="border-radius: 10px; border: 3px solid #cdb87d; margin-right: 462px;">
      <div id="AdvBoard" class="tabcontent">
    <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><div class="template">
            <div style="background: #cdb87d">
                <div style="font-size: 20px;">
                <h2 style="padding: 10px;"><b><center>Advisory Board Members in all 4 Categories</center></b></h2>
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
            <div style="background: #cdb87d">
                <div style="font-size: 20px;">
                <h2 style="padding: 10px;"><b><center>PBAA Elected Board Members</h2></b></center>
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

    <script>
        /* Set the width of the side navigation to 250px */
        function openNav() {
            document.getElementById("mySidenav").style.width = "350px";
        }

        /* Set the width of the side navigation to 0 */
        function closeNav() {
            document.getElementById("mySidenav").style.width = "0";
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
