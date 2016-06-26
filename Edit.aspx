<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 62px;
            width: 311px;
        }
    </style>
    <link href="css/EditdbTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" runat="server">
    <div>
        
        <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate><table id="editTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="idLabel" Text='<%# Eval("Id") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="photoLabel" Text='<%# Eval("photo") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="nameLabel" Text='<%# Eval("name") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="profileLabel" Text='<%# Eval("profile") %>' runat="server"></asp:Label></td>
                <td><asp:LinkButton ID ="deleteLink" Text="Delete" runat="server" OnClick="Delete_Click"></asp:LinkButton></td>
                <td><asp:LinkButton ID ="editLink" Text="Edit" runat="server"></asp:LinkButton></td>
                </tr>
                </div>

            </ItemTemplate>


            <FooterTemplate></table></FooterTemplate>

        </asp:Repeater>
        
    </div>
        <div>
        <p>
            <asp:Label ID="LName" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LPhoto" runat="server" Text="Photo"></asp:Label>
            :
            <asp:FileUpload ID="ImageUpload" runat="server" Height="33px" Width="320px" />
        <p>
            <asp:Label ID="LProfile" runat="server" Text="Profile"></asp:Label>
            :
            <asp:TextBox ID="txtProfile" runat="server" Width="200px" Height="70px" TextMode="multiLine"></asp:TextBox>
        </p>
            <p>
                <asp:Button ID="SubButton" runat="server" Text="Submit" OnClick="SubButton_Click" />
            </p>
            <a href="Donor_Testimonials.aspx">Edit Stuff</a>
        </div>
    </form>
</body>
</html>
