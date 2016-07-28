<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donor_Map.aspx.cs" Inherits="History" %>

<!DOCTYPE html>
<!--
    Need to fill out for Testimonial Map, Part of Testimonial Package, Ignore everything else.
    -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/Donor_Map.css" rel="stylesheet" type="text/css" />
    <link href="~/css/Donor_Map_Menu.css" rel="stylesheet" type="text/css" />
    <link href="~/css/Donor_MapForms.css" rel="stylesheet" type="text/css" />
    <link href="css/Donor_Accordian.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/Stroll_Layout.css" rel="stylesheet" type="text/css" />
    <link href="css/Stroll_Css/stroll.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="css/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script src="Javascript/Donor_JS/Donor_JS.js"></script>
    <script src="Javascript/Search_JS/jquery.quicksearch.js"></script>
    <script src="Javascript/Popup_JS/jquery.popupoverlay.js"></script>
</head>
<body>
    <div class="distribution-map">
        <a class="map-point initialism FisherForm_open" id="Fisher_Point" href="#FisherForm"></a>
        <a class="map-point initialism CommonsForm_open" id="Commons_Point" href="#CommonsForm"></a>
        <a class="map-point initialism LibraryForm_open" id="Hanley_Point" href="#LibraryForm"></a>
        <a class="map-point initialism SwartsForm_open" id="Swarts_Point" href="#SwartsForm"></a>
        <a class="map-point initialism BlaisdellForm_open" id="Blaisdell_Point" href="#BlaisdellForm"></a>
        <a class="map-point initialism FitnessCenterForm_open" id="FitnessCenter_Point" href="#FitnessCenterForm"></a>
        <a class="map-point initialism ResidenceForm_open" id="Residence_Point" href="#ResidenceForm"></a>
    </div>

    <div id="FisherForm">
    <iframe id="FisherId" frameborder="0" height="500" width="1080" src="FormPages/FisherHall.aspx"></iframe>
    </div>
    <div id="CommonsForm">
    <iframe id="CommonsId" frameborder="0" height="500" width="1080" src="FormPages/Commons.aspx"></iframe>
    </div>
    <div id="LibraryForm">
    <iframe id="LibraryId" frameborder="0" height="500" width="1080" src="FormPages/Library.aspx"></iframe>
    </div>
    <div id="SwartsForm">
    <iframe id="SwartsId" frameborder="0" height="500" width="1080" src="FormPages/SwartsHall.aspx"></iframe>
    </div>
    <div id="BlaisdellForm">
    <iframe id="BlaisdellId" frameborder="0" height="500" width="1080" src="FormPages/BlaisdellHall.aspx"></iframe>
    </div>
    <div id="FitnessCenterForm">
    <iframe id="FitnessCenterId" frameborder="0" height="500" width="1080" src="FormPages/FitnessCenter.aspx"></iframe>
    </div>
    <div id="ResidenceForm">
    <iframe id="ResidenceId" frameborder="0" height="500" width="1080" src="FormPages/Residence.aspx"></iframe>
    </div>

<script>
$(document).ready(function () {

    $('#FisherForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#CommonsForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#LibraryForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#SwartsForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#BlaisdellForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#FitnessCenterForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

    $('#ResidenceForm').popup({
        pagecontainer: '.container',
        transition: 'all 0.3s',
    });

});
</script>

<style>

</style>

    <footer>
        <div class="footer">
        <a href="Recognition_Home.aspx"><div class="menubar one">
            <img src="Images/Home_Assets/Icons/Donor_Icon.png" alt="" class="icon" />
        </div></a>
            </div>
    </footer>

</body>
</html>
