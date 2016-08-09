<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Content_Management.aspx.cs" Inherits="Content_Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 62px;
            width: 311px;
        }
        .LinkPad{
            padding-right: 5px;
        }
    </style>
    <link href="css/Content_Management.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script type="text/javascript" src="Javascript/Leadership_JS/Leadership.js"></script>
    <script src="Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body onload="openCity(event, 'TestimonialsFrame')">
    <form id="form1" runat="server">
    <ul class="tab" runat="server">
        <li><a id="TestimonialTab" href="#" class="tablinks" runat="server" onclick="openCity(event, 'TestimonialsFrame')">Testimonial Controls</a></li>
        <li><a id="LeadershipTab" href="#" class="tablinks" runat="server" onclick="openCity(event, 'LeadershipFrame')">Leadership Controls</a></li>
        <li><a id="RecognitionTab" href="#" class="tablinks" runat="server" onclick="openCity(event, 'RecognitionFrame')">Recognition Controls</a></li>
        <li><a id="MapTab" href="#" class="tablinks" runat="server" onclick="openCity(event, 'MapFrame')">Map Controls</a></li>
        <li><a id="UploadTab" href="#" class="tablinks" runat="server">Upload Controls</a></li>
        <li><a href="Donor_Testimonials.aspx">Exit</a></li>
    </ul>
    <div id="TestimonialsFrame" class="tabcontent">
        <iframe id="TestimonialFrameId" frameborder="0" height="900" width="100%" src="ContentPages/TestimonialManagement.aspx"></iframe>
    </div>
    <div id="LeadershipFrame" class="tabcontent">
        <iframe id="LeadershipFrameId" frameborder="0" height="900" width="100%" src="ContentPages/LeadershipManagement.aspx"></iframe>
    </div>
    <div id="RecognitionFrame" class="tabcontent">
        <iframe id="RecognitionFrameId" frameborder="0" height="900" width="100%" src="ContentPages/RecognitionManagement.aspx"></iframe>
    </div>
    <div id="MapFrame" class="tabcontent">
        <iframe id="MapFrameId" frameborder="0" height="900" width="100%" src="ContentPages/MapManagement.aspx"></iframe>
    </div>
    <div id="UploadFrame">
    </div>
    </form>
</body>
</html>
