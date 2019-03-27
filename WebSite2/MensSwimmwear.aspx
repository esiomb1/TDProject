<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="MensSwimmwear.aspx.cs" Inherits="MensSwimmwear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style21 {
            height: 406px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    No of products in your shopping cart:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>


    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ClothingCheckout.aspx">Show Cart</asp:HyperLink>
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CartConnectionString %>" SelectCommand="SELECT Productid, Description, Price, ProductType, ProductImage FROM Product WHERE (ProductType = 'MensSwimmwear')"></asp:SqlDataSource>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Productid" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal" Height="609px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
                <table border="1" class="auto-style21">
                <tr>
                    <td class="auto-style25">ProductId<asp:Label ID="Label1" runat="server" Text='<%# Eval("Productid") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">Price<asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">ProductType<asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductType") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ProductImage") %>' Height="400px" Width="350px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" CommandArgument='<%#  Eval("Productid")%>' CommandName="addtocart" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </ItemTemplate>
       
    </asp:DataList>
</asp:Content>

