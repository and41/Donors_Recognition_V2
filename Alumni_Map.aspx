<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumni_Map.aspx.cs" Inherits="Alumni_Map" %>

<!DOCTYPE html>
<!--
    Need to fill out for Testimonial Map, Part of Testimonial Package, Ignore everything else.
    -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/Alumni_Map.css" rel="stylesheet" type="text/css" />
    <link href="~/css/Alumni_Map_Menu.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body>
    <img src="Images/Alumni_Assets/Alumni_Map.png"/>


    <form id="form1" runat="server">
    <asp:Label ID="lblAlabama" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblAlaska" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblArizona" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblArkansas" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblCalifornia" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblColorado" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblConnecticut" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblDelaware" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblFlorida" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblGeorgia" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblHawaii" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblIdaho" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblIllinois" runat="server" Text="Foo" ></asp:Label>

    <asp:Label ID="lblIndiana" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblIowa" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblKansas" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblKentucky" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblLouisiana" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMaine" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMaryland" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMassachusetts" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMichigan" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMinnesota" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMississippi" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMissouri" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblMontana" runat="server" Text="Foo" ></asp:Label>

    <asp:Label ID="lblNebraska" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNevada" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNewHampshire" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNewJersey" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNewMexico" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNewYork" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNorthCarolina" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblNorthDakota" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblOhio" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblOklahoma" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblOregon" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblPennsylvania" runat="server" Text="Foo" ></asp:Label>

    <asp:Label ID="lblRhodeIsland" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblSouthCarolina" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblSouthDakota" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblTennessee" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblTexas" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblUtah" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblVermont" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblVirginia" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblWashington" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblWestVirginia" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblWisconsin" runat="server" Text="Foo" ></asp:Label>
    <asp:Label ID="lblWyoming" runat="server" Text="Foo" ></asp:Label>

    </form>


    
    <div class="initialism InfoBox_open" style="border: 2px solid black; border-radius: 10px; background: white; z-index: 1; color: black; width: 200px; position: absolute; top: 700px; left: 1450px; padding: 10px;">
    <a href="#InfoBox" style="text-decoration:none; color: black;">Click here for more Info...</a>
    </div>

    <div id="InfoBox" style="border: 2px solid black; border-radius: 10px; background: white; color: black; padding: 10px; width: 400px;">
        <p>Since 1963, the University of Pittsburgh at Bradford has grown from a two-year college to a friendly, safe campus where students can earn a world-renowned degree in a personalized environment.</p>
        <p>Pitt-Bradford alumni are located in each of the 50 united states and throughout the world.  On the map, the number of living alumni is listed per state for a total of 11,307.</p>
    </div>

<script>
    $(document).ready(function () {

    $('#InfoBox').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s'
    });
});
</script>

    <footer>
        <div class="footer">
        <a href="Default.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
        </div></a>
            </div>
    </footer>

</body>
</html>
