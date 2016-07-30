<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Outdoors.aspx.cs" Inherits="FormPages_Outdoors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/Donor_MapForms.css" rel="stylesheet" type="text/css" />
    <link href="../css/Stroll_Css/Stroll_Layout.css" rel="stylesheet" type="text/css" />
    <link href="../css/Stroll_Css/stroll.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="../Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body>
    <form id="form1" runat="server">
      <div id="AdvBoard" class="tabcontent">
    <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
            <table id="viewTable""></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label Text='<%# Eval("Location") %>' runat="server"></asp:Label></td>
                <td><asp:Label Text='<%# Eval("Donor Name") %>' runat="server"></asp:Label></td>
                <td><asp:Label Text='<%# Eval("Name of Area") %>' runat="server"></asp:Label></td>
                <td><asp:Label Text='<%# Eval("Wording on Plaque") %>' runat="server"></asp:Label></td>
                <td><asp:Label Text='<%# Eval("Dedication Date") %>' runat="server"></asp:Label></td>
                </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    </form>

    <div id="OutdoorsStone">
    <div id="DivPopup">
    <p id="DivPopupId">
    This monument marks the site of the Taylor Aircraft Company, manufacturer of the Taylor Cub designed by C.G. Taylor and largely financed by William T. Piper. The factory produced airplanes from 1929 until March 16, 1937, when it was destroyed by fire. 
    </br></br>Piper moved the company to Lock Have, Pa., and changed its name to the Piper Aircraft Corporation. Taylor left the company in late 1935 to start his own firm in Alliance, Ohio, the Taylorcraft Company.
    </br></br>From these small Bradford beginnings evolved two of the greatest American light planes:  the Taylorcraft and the Piper Cub.
    </p>
    </div>
    </div>

<script>
    $(document).ready(function () {

        $('#OutdoorsStone').popup({
            pagecontainer: '.container',
            transition: 'all 0.3s',
        });
    });
</script>

</body>
</html>
