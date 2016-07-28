<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BlaisdellHall.aspx.cs" Inherits="FormPages_BlaisdellHall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/Donor_MapForms.css" rel="stylesheet" type="text/css" />
    <link href="../css/Donor_Accordian.css" rel="stylesheet" type="text/css" />
    <link href="../css/Stroll_Css/Stroll_Layout.css" rel="stylesheet" type="text/css" />
    <link href="../css/Stroll_Css/stroll.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="../Javascript/Donor_JS/Donor_JS.js"></script>
    <script src="../Javascript/Search_JS/jquery.quicksearch.js"></script>
    <script src="../Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body>

    <div id="FormFade" class="FormBorder">
        <form runat="server">
        <nav class="SearchNav">
            <div class="DonorSearch">
            <input id="SearchBox" type="text" placeholder="Search" />
            </div>
            <div class="DonorList">
            <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <ul id="SearchListDB" class="grow"></HeaderTemplate>
            <ItemTemplate>
                    <asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server" Visible="false"></asp:Label>
                    <li><asp:Linkbutton ID="LinkButton" cssClass="LiLink" Text='<%# Eval("RoomId") %>' runat="server" OnClick="SearchClick_Click"></asp:Linkbutton></a></li>              
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
            </div>
            <div>
            <script src="../Javascript/Stroll_JS/stroll.js"></script>
            <script>
			var list = document.querySelector( 'ul' );
			var type = window.location.search.slice( 1 ) || 'grow';

			list.className = type;
			
			window.addEventListener( 'resize', updateHeight, false );

			updateHeight();

			function updateHeight() {
				list.style.height = window.innerHeight + 'px';
				stroll.bind( 'ul' );
			}
		</script>
            </div>
        </nav>

        <script>
        $(document).ready(function () {
        $('input#SearchBox').quicksearch('ul#SearchListDB li');
        });
        </script>

        </form>
        <div class="ContentDiv">
            <div class="HeaderContentDiv">
                <h1 class="ContentTitle">Blaisdell Hall</h1>
                <b><p id="ContentParagraph1">Named in honor of the Blaisdell Family, along with their family foundation, the Philo and Sarah Blaisdell Foundation; and their companies, Zippo Manufacturing and W.R. Case & Sons Cutlery, because of their stong interest in the University along with their tremendous level and duration of suppor to Pitt-Bradford since its establishment.  </p>
                </b>
            </div>
            <div id="accordion" runat="server">
            </div>
        </div>
    </div>
</body>
</html>
