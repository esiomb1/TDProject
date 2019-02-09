<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SummaryPage.aspx.cs" Inherits="EliteAir.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 108px">

    </div>
    <div style="height: 460px">

        <h3>Booking Confirmed </h3>
        <p>
            Passenger&nbsp;&nbsp;
            <asp:Label ID="lblPassenger" runat="server"></asp:Label>
        </p>
        <p>
            Departure Date and Time&nbsp;&nbsp;
            <asp:Label ID="lblDDAT" runat="server"></asp:Label>
        </p>
        <p>
            Return Date and time
            <asp:Label ID="lblRDAT0" runat="server"></asp:Label>
        </p>
        <p>
            Cost
            <asp:Label ID="lblCost" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="32px" Text="Home Page " Width="205px" OnClick="Button2_Click" />
        </p>

    </div>
</asp:Content>
