<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donor_Testimonials.aspx.cs" Inherits="Donors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donors</title>
    <link href="css/Donor_Accordian.css" rel="stylesheet" type="text/css" />
    <link href="css/Testimonial.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/Stroll_Layout.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/stroll.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="Javascript/Donor_JS/Donor_JS.js"></script>
    <script src="Javascript/Search_JS/jquery.quicksearch.js"></script>
</head>

<body>

    <a href="Content_Management.aspx">To Edit</a>
    <div id="FormFade-Testimonials" class="FormBorder-Testimonials">
        <form runat="server">
        <nav class="SearchNav-Testimonials">
            <div class="DonorSearch-Testimonials">
            <input id="SearchBox-Testimonials" type="text" placeholder="Search" />
            </div>
            <div class="DonorList-Testimonials">
            <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <ul id="SearchListDB-Testimonials" class="grow"></HeaderTemplate>
            <ItemTemplate>
                    <asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server" Visible="false"></asp:Label>
                    <li><asp:Linkbutton ID="LinkButton" cssClass="LiLink" Text='<%# Eval("Name") %>' runat="server" OnClick="SearchClick_Click"></asp:Linkbutton></a></li>              
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
            $('input#SearchBox-Testimonials').quicksearch('ul#SearchListDB-Testimonials li');
        });
        </script>

        </form>
        <div>
            <div id="accordion" class="accordion-Testimonials" runat="server">
            </div>
        </div>
    </div>

    <footer class="FooterTab-Testimonials">
        <div class="footer-Testimonials">
        <a href="Default.aspx"><div class="menubar">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label"></p>
        </div></a>
        <a href="Donor_Gallery.aspx"><div class="menubar">
            <img src="Images/Home_Assets/Icons/Gallery_Icon.png" alt="" class="icon" />
            <p class="label"></p>
        </div></a>
        </div>
    </footer>
</body>
</html>
