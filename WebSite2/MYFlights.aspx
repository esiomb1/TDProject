<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MYFlights.aspx.cs" Inherits="EliteAir.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        My Booked Flights

    </div>
    <div style="height: 358px">


        <asp:ListBox ID="ListBox1" runat="server" Height="123px" Width="674px"></asp:ListBox>


        <br />
        <br />
        <asp:Button ID="btnCancel" runat="server" Height="28px" Text="Cancel Selected Flight" Width="197px" OnClick="btnCancel_Click" />
&nbsp;&nbsp;
        <asp:Button ID="btnHome" runat="server" Text="Home" Width="146px"  OnClick="btnHome_Click" />
        <br />


    </div>
</asp:Content>
