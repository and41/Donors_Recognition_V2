<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SwartsHall.aspx.cs" Inherits="FormPages_SwartsHall" %>

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
                <h1 class="ContentTitle">Swarts Hall</h1>
                <b><p id="ContentParagraph1">Swarts Hall - In 1963, The Chancellor of the University charged Dr. Donald E. Swarts with the task of establishing a branch campus of the University of Pittsburgh.  Dr. Swarts, a scholar an able administrator, organized community support, obtained faculty, attracted a student body, and until July 1973 served as campus president.  This academic building bears his name in tribute to his leadership in establishing this campus and to his untiring effort in bring advantages of higher education to Northwestern Pennsylvania. <a class="initialism SwartsPopup_open" id="SwartsPopupId" href="#SwartsPopup">Read More...</a></p>
            </div>
            <div id="accordion" runat="server">
            </div>
        </div>

    <div id="SwartsPopup">
    <div id="DivPopup">
    <p id="DivPopupId">Swarts Hall was completely renovated during Fall 2007 and Spring 2008 to accommodate the growth in student population and the need for more faculty offices and departmental space.  The renovated facility was reopened for classes in Spring 2008.
        </br></br>Among the new additions to the building were an 80-seat state-of-the-art distance education center, new faculty offices, and a wing dedicated to the university's expanding nurisng program. 
        </br></br>As part of the ceremony, the Jack and Martha M. Campbell Wing and the Osborne E-Venture Lab were dedicated and the following areas were rededicated: William F. HIgie Wing, Rhea Osborne O' Kain Wing, The DeFrees Family Foundation Multi-Medica Classroom, The Stackpole-Hall Nursing Lab, and the Verizon Foundation Information Technology Laboratory</p>
    </div>
    </div>

<script>
$(document).ready(function () {

    $('#SwartsPopup').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

});
</script>

    </div>
</body>
</html>
