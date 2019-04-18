<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhonePage.aspx.cs" Inherits="PhonePage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="StyleSheet.css" rel="StyleSheet"/>

</head>

<body>
    <img src="H:\Documents\finalting\PhonesToGoWebsite\Pictures\Untitled.jpg"alt="" style="width: 100%; margin-bottom: 0px;"/>
    <form id="form1" runat="server">
        <nav id="menu">
                    <ul>
                        <li><a href="HomePage.aspx">Home</a></li>
                        <li><a href="PhonePage.aspx">Phones Page</a></li>
                        <li><a href="AboutUs.aspx">About Us</a></li>
                        <li><a href="ContactUs.aspx">Contact Us</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </li>
                            <asp:Button ID="bntSearch" runat="server" Text="Search" />
                            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                    </ul>
                </nav>
        <div>
            PhonePage</div>
    </form>
</body>
</html>

