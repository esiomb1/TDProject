<%@ Page Language="C#" AutoEventWireup="true" CodeFile="eResultsPAge.aspx.cs" Inherits="eResultsPAge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        Start Date
        <asp:TextBox ID="txtStartDate" runat="server">10/1/2018</asp:TextBox>
        <br />
        <br />
        End Date
        <asp:TextBox ID="txtEndDate" runat="server">15/1/2018</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="Go" />
        <br />
        <br />
        Available Widgets<br />
        <br />
        <asp:ListBox ID="lstAvailable" runat="server" Height="327px" Width="390px" OnSelectedIndexChanged="lstAvailable_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>
