<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="css/Home.css" rel="stylesheet" type="text/css" />
    <link href="css/Swiper_Css/swiper.min.css" rel="stylesheet" type="text/css" />
    <!--Keep Swiper_Css Here at end, else will mess with Swiper in Page-->
    <link href="css/Swiper_Css/Home_Swiper.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <script type="text/javascript" src="Javascript/Swiper/swiper.min.js"></script>
    
    <div class="swiper-container" style="position: fixed; margin-top: -50px;">
        <div id="SlideShowDiv" class="swiper-wrapper" runat="server">
        </div>

        <div class="swiper-button-prev"></div>
        <div class="swiper-button-next"></div>
    </div>
    <footer>
        <div class="footer">
        <div class="footer-div">
        <a href="Default.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label">Home</p>
        </div></a>
        <a href="Recognition_Home.aspx"><div class="menubar two">
            <img src="Images/Home_Assets/Icons/Rec_Icon.png" alt="" class="icon" />
            <p class="label">Recognition</p>
        </div></a>
        <a href="History.aspx"><div class="menubar three">
            <img src="Images/Home_Assets/Icons/History_Icon.png" alt="" class="icon" />
            <p class="label">History</p>
        </div></a>
        <a href="Donor_Testimonials.aspx"><div class="menubar four">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
            <p class="label">Testimonials</p>
        </div></a>
        <a href="Leadership.aspx"><div class="menubar five">
            <img src="Images/Home_Assets/Icons/Leadership_Icon.png" alt="" class="icon" />
            <p class="label">Leadership</p>
        </div></a>
        <a href="Events.aspx"><div class="menubar six">
            <img src="Images/Home_Assets/Icons/Event_Icon.png" alt="" class="icon" />
            <p class="label">Events</p>
        </div></a>
        <a href="Donor_Map.aspx"><div class="menubar seven">
            <img src="Images/Home_Assets/Icons/Map_Icon.png" alt="" class="icon" />
            <p class="label">Donor Map</p>
        </div></a>
        <a href="Alumni_Map.aspx"><div class="menubar eight">
            <img src="Images/Home_Assets/Icons/Alum_Icon.png" alt="" class="icon" />
            <p class="label">Alumni Map</p>
        </div></a>
        </div>
        </div>
    </footer>

    <!-- Keep Line of Script Reference at End, Else will mess with Swiper in Page-->
    <script type="text/javascript" src="Javascript/Swiper/Home_Swiper.js"></script>
</body>
</html>
