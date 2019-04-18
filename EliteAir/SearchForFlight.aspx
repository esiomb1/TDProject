<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SearchForFlight.aspx.cs" Inherits="EliteAir.SearchForFlight" %>
<asp:Content ID="nav" runat="server" contentplaceholderid="nav">
</asp:Content>

<asp:Content ID="Content" runat="server" contentplaceholderid="Content">
    <form id="form1" runat="server">
    <p>
        Look Below for the List of Available Flights</p>
        <p>
    &nbsp;<asp:ListBox ID="lstSF" runat="server" Height="290px" OnSelectedIndexChanged="lstSF_SelectedIndexChanged" Width="389px"></asp:ListBox>
    &nbsp;&nbsp;
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</asp:Content>



