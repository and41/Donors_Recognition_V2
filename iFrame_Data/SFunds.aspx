<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SFunds.aspx.cs" Inherits="iFrame_Data_SFunds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/iFrame_Css/SFunds.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><table id="viewTable"></HeaderTemplate>
            <ItemTemplate>
                <div>
                        <tr class="<%# Container.ItemIndex % 2 == 0 ? "rowOdd" : "rowEven" %>">
                <td><asp:Label ID="donorFund" Text='<%# Eval("Fund") %>' runat="server"></asp:Label></td>
                <td><asp:Label ID="establishedBy" Text='<%# Eval("Established") %>' runat="server"></asp:Label></td>
                        </tr>
                </div>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </form>


</body>
</html>
