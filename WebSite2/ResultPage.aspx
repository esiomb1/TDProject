<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="EliteAir.WebForm1" %>

<script runat="server">

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:TextBox ID="txtSD" runat="server"></asp:TextBox>
&nbsp;&nbsp; from&nbsp;&nbsp;
        <asp:TextBox ID="txtED" runat="server"></asp:TextBox>
        till&nbsp;&nbsp;
        <asp:Button ID="btngo" runat="server" Text="Button" />
&nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="374px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="329px"></asp:ListBox>
    </p>
</asp:Content>
