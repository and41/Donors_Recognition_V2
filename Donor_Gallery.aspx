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
        <div id="SlideShowDiv" data-u="slides" runat="server" style="cursor: default; border-radius: 10px; position: relative; top: 0px; left: 0px; width: 1280px; height: 700px; overflow: hidden;">
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
        <a href="Donor_Testimonials.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
        </div></a>
            </div>
    </footer>
</body>
</html>
