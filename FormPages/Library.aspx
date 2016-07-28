<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Library.aspx.cs" Inherits="FormPages_Library" %>

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
                <h1 class="ContentTitle">T. Edward and Tullah Hanley Library</h1>
                <b><p id="ContentParagraph1">T. Edward Hanley was named as a member of the honorary board of advisors. A world-famous art collector, oil executive and patron of several libraries, colleges, schools, and universities, including Pitt-Bradford and nearby St. Bonaventure, he gave a fortune away in terms of art and books during his lifetime. He was born in Bradford in 1893, the son of William Hanley, founder of Hanley Brick and Hanley Oil and Gas, and graduated from Harvard University in 1915. As a member of the Advisory Board, his financial support and donation of thousands of books were critical in establishing the Pitt-Bradford library, which was named the T. Edward and Tullah Hanley Library in March 1988. </p>
                </b>
            </div>
            <div id="accordion" runat="server">
            </div>
        </div>
    </div>
</body>
</html>
