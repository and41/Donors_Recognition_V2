<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BackgroundManagement.aspx.cs" Inherits="ContentPages_BackgroundManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    
    </div>
        <%--Section for Background Management, when selected and submitted, will change background of page section--%>
        <asp:DropDownList ID="BackgroundSelect" runat="server">
            <asp:ListItem>Home_Page</asp:ListItem>
            <asp:ListItem>Events_Page</asp:ListItem>
            <asp:ListItem>Gallery_Page</asp:ListItem>
            <asp:ListItem>History_Page</asp:ListItem>
            <asp:ListItem>Leadership_Page</asp:ListItem>
            <asp:ListItem>Recognition_Page</asp:ListItem>
            <asp:ListItem>Testimonials_Page</asp:ListItem>
        </asp:DropDownList>

        &nbsp;<asp:FileUpload ID="ImageUpload" runat="server" Height="33px" Width="320px" />
        
        &nbsp;
        
        <asp:Button ID="SubButton" runat="server" Text="Submit" OnClick="SubButton_Click" />
        <br />
        <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
