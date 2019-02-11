

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <p>
      Select order:
      <asp:DropDownList ID="Order" runat="server" DataSourceID="CategoriesData" 
        DataTextField="OrderName" DataValueField="OrderID" AutoPostBack="true" />
      <asp:SqlDataSource ID="OrderData" runat="server" 
        ConnectionString="<%$ ConnectionStrings:clsDataConnection.cs %>"
        SelectCommand="SELECT [ProductID], [ProductName] FROM [Product]"></asp:SqlDataSource>
    </p>
</body>
</html>
