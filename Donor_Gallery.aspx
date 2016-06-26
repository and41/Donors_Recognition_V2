<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donor_Gallery.aspx.cs" Inherits="Gallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/Gallery.css" rel="stylesheet" type="text/css" />
    <link href="~/css/Jssor_Css/Gallery_Jssor.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <script type="text/javascript" src="Javascript/Jssor/jquery-1.11.3.min.js"></script>
    <script type="text/javascript" src="Javascript/Jssor/jssor.slider.mini.js"></script>
    <script type="text/javascript" src="Javascript/Gallery_JS/Gallery_JS.js"></script>

    <div id="jssor_1" style="position: relative; margin: 0 auto; top: 15px; left: 0px; width: 1280px; height: 700px; overflow: hidden; visibility: hidden;">
        <!-- Loading Screen -->
        <div data-u="loading" style="position: absolute; top: 0px; left: 0px;">
            <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
            <div style="position:absolute;display:block;background:url('img/loading.gif') no-repeat center center;top:0px;left:0px;width:100%;height:100%;"></div>
        </div>
        <div data-u="slides" style="cursor: default; border-radius: 10px; position: relative; top: 0px; left: 0px; width: 1280px; height: 700px; overflow: hidden;">
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/002.jpg" />
                <img data-u="thumb" src="img/002.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/003.jpg" />
                <img data-u="thumb" src="img/thumb-003.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/004.jpg" />
                <img data-u="thumb" src="img/thumb-004.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/005.jpg" />
                <img data-u="thumb" src="img/thumb-005.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/006.jpg" />
                <img data-u="thumb" src="img/thumb-006.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/007.jpg" />
                <img data-u="thumb" src="img/thumb-007.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/008.jpg" />
                <img data-u="thumb" src="img/008.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/009.jpg" />
                <img data-u="thumb" src="img/009.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/010.jpg" />
                <img data-u="thumb" src="img/010.jpg" />
            </div>
            <div data-p="112.50" style="display: none;">
                <img data-u="image" src="img/011.jpg" />
                <img data-u="thumb" src="img/thumb-011.jpg" />
            </div>
        
        </div>
        <!-- Thumbnail Navigator -->
        <div u="thumbnavigator" class="jssort03" style="position:absolute;left:0px;bottom:0px;width:1280px;height:60px;" data-autocenter="1">
            <div style="position: absolute; top: 0; left: 0; width: 100%; height:100%; background-color: #000; filter:alpha(opacity=30.0); opacity:0.3;"></div>
            <!-- Thumbnail Item Skin Begin -->
            <div u="slides" style="cursor: default;">
                <div u="prototype" class="p">
                    <div class="w">
                        <div u="thumbnailtemplate" class="t"></div>
                    </div>
                    <div class="c"></div>
                </div>
            </div>
            <!-- Thumbnail Item Skin End -->
        </div>
        <!-- Arrow Navigator -->
        <span data-u="arrowleft" class="jssora02l" style="top:0px;left:8px;width:55px;height:55px;" data-autocenter="2"></span>
        <span data-u="arrowright" class="jssora02r" style="top:0px;right:8px;width:55px;height:55px;" data-autocenter="2"></span>
    </div>







    <footer>
        <div class="footer">
        <a href="Home.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Home_Icon.png" alt="" class="icon" />
            <p class="label">Home</p>
        </div></a>
        <a href="Donors.aspx"><div class="menubar two">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
            <p class="label">Donors</p>
        </div></a>
        <a href="Leadership.aspx"><div class="menubar three">
            <img src="Images/Home_Assets/Icons/Leadership_Icon.png" alt="" class="icon" />
            <p class="label">Leadership</p>
        </div></a>
        <a href="History.aspx"><div class="menubar four">
            <img src="Images/Home_Assets/Icons/History_Icon.png" alt="" class="icon" />
            <p class="label">History</p>
        </div></a>
        <a href="Gallery.aspx"><div class="menubar five">
            <img src="Images/Home_Assets/Icons/Gallery_Icon.png" alt="" class="icon" />
            <p class="label">Gallery</p>
        </div></a>
        </div>
    </footer>
</body>
</html>
