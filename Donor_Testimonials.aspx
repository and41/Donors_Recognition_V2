<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donor_Testimonials.aspx.cs" Inherits="Donors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donors</title>
    <link href="~/css/Recognition.css" rel="stylesheet" type="text/css" />
    <link href="css/Donor_Accordian.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/Stroll_Layout.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/stroll.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="Javascript/Donor_JS/Donor_JS.js"></script>
    <script src="Javascript/Search_JS/jquery.quicksearch.js"></script>
</head>

<body>
    
    <a href="Edit.aspx">Back to Testimonials</a>
    <div class="FormBorder">
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
                    <li><asp:Linkbutton cssClass="LiLink" Text='<%# Eval("Name") %>' runat="server" OnClick="SearchClick_Click"></asp:Linkbutton></a></li>              
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
            </div>
            <div>
            <script src="Javascript/Stroll_JS/stroll.js"></script>
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
            <div id="accordion" runat="server">
            </div>
        </div>
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
