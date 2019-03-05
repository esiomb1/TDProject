<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="CustomerAddEditDelete.aspx.cs" Inherits="CustomerAddEditDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />

    <br />
    <br />
    <asp:GridView ID="GridViewCustomer" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomersId,UserId" DataSourceID="SqlDataSource1" Height="317px" Width="641px" AllowPaging="True" AllowSorting="True" ShowFooter="True" style="margin-left: 29px; margin-top: 0px;">
       
        <Columns>


            <asp:TemplateField HeaderText="CustomersId" InsertVisible="False" SortExpression="CustomersId">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("CustomersId") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("CustomersId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>  
            <asp:TemplateField HeaderText="UserId" InsertVisible="False" SortExpression="UserId">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("UserId") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("UserId") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:LinkButton ID="AddCustomer"  runat="server" OnClick="Click_addcustomer">Add Customer</asp:LinkButton>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" SortExpression="Email">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="CustomerName" SortExpression="CustomerName">
                <EditItemTemplate>
                    <asp:TextBox ID="txtCustomerName" runat="server" Text='<%# Bind("CustomerName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("CustomerName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
          

           
        </Columns>
    
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CartConnectionString %>" DeleteCommand="DELETE FROM Customers FROM Customers INNER JOIN Users ON Customers.UserId = Users.UserId" SelectCommand="SELECT FROM Customers INNER JOIN Users ON Customers.UserId = Users.UserId" UpdateCommand="UPDATE Customers SET FROM Customers INNER JOIN Users ON Customers.UserId = Users.UserId"></asp:SqlDataSource>
    &nbsp;
    &nbsp;&nbsp;
    &nbsp;<br />
    <br />
    <br />
    <br />
&nbsp;
    <br />
    </asp:Content>

