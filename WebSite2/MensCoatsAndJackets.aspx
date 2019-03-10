<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="MensCoatsandJackets.aspx.cs" Inherits="MensCoatsandJackets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style21 {
            width: 100%;
        }
        .auto-style22 {
            height: 23px;
            text-align: center;
            width: 340px;
        }
        .auto-style24 {
            text-align: center;
            height: 25px;
            width: 340px;
        }
        .auto-style25 {
            text-align: center;
            width: 340px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Productid" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal" Width="337px">
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
                    <td class="auto-style25">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ProductImage") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <br /> 
    <br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CartConnectionString %>" SelectCommand="SELECT Productid, Description, Price, ProductType, ProductImage FROM Product WHERE (ProductType = N'MensJacket')">
</asp:SqlDataSource>
    <br />
</asp:Content>

