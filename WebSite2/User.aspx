<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="UserId" DataSourceID="SqlDataSource1" Width="680px" Height="310px" ShowFooter="True" >
        <Columns>
            <asp:CommandField ShowEditButton="True" ValidationGroup="editvalidation"/>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="UserId" SortExpression="UserId">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("UserId") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("UserId") %>'></asp:Label>
                </ItemTemplate>
                 <FooterTemplate>
                    <asp:LinkButton ID="LinkButton1"  runat="server" OnClick="Click_adduser" ValidationGroup="addvalidation" >Add User</asp:LinkButton>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PasswordName" SortExpression="PasswordName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("PasswordName") %>' TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="refpasswordnameedit" runat="server" ErrorMessage="*" Text="*" ControlToValidate="TextBox1" ValidationGroup="editvalidation" class="error"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("PasswordName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtPasswordName" runat="server"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="reqPasswordName" runat="server" ErrorMessage="enter the password" Text="*" ControlToValidate="txtPasswordName" ValidationGroup="addvalidation" class="error"></asp:RequiredFieldValidator>

                </FooterTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server"  class="error" ForeColor="#CC3300" ShowMessageBox="True" DisplayMode="List" style="margin-bottom: 3px" ValidationGroup="addvalidation"/>
    

    <br />
<br />
<br />
<br />
<br />
<br />
    

    <br />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CartConnectionString %>" DeleteCommand="DELETE FROM [Users] WHERE [UserId] = @UserId" InsertCommand="INSERT INTO [Users] ([PasswordName]) VALUES (@PasswordName)" SelectCommand="SELECT * FROM [Users]" UpdateCommand="UPDATE [Users] SET [PasswordName] = @PasswordName WHERE [UserId] = @UserId">
        <DeleteParameters>
            <asp:Parameter Name="UserId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="PasswordName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="PasswordName" Type="String" />
<asp:Parameter Name="UserId" Type="Int32"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

