<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FitnessCenter.aspx.cs" Inherits="FormPages_FitnessCenter" %>

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

    <div id="FormFade" class="FormBorderReg">
        <form runat="server">
        <nav class="SearchNavReg">
            <div class="DonorSearch">
            <input id="SearchBox" type="text" placeholder="Search" />
            </div>
            <div class="DonorList">
            <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <ul id="SearchListDBReg" class="grow"></HeaderTemplate>
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
        $('input#SearchBox').quicksearch('ul#SearchListDBReg li');
        });
        </script>

        </form>
        <div class="ContentDivReg">
            <div class="HeaderContentDivReg">
                <h1 class="ContentTitle">Dr. Richard and Ruth McDowell Sport and Fitness Center</h1>
            </div>
            <div id="accordion" runat="server">
            </div>
        </div>
    </div>
</body>
</html>
