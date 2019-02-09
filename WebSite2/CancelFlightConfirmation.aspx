<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelFlightConfirmation.aspx.cs" Inherits="EliteAir.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div style="height: 108px">

    </div>
    <div style="height: 460px">

        <h2>Cancellation Confirmation </h2>
        <p>
            Passenger&nbsp;&nbsp;
            <asp:Label ID="lblPassenger" runat="server"></asp:Label>
        </p>
        <p>
            Departure Date and Time&nbsp;&nbsp;
            <asp:Label ID="lblDDAT" runat="server"></asp:Label>
        </p>
        <p>
            Cost
            <asp:Label ID="lblCost" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
         
         <h5> Your Flight Has Been Cancelled Succsefully  <asp:Button ID="btnHome" runat="server" Height="32px" Text="Home Page " Width="205px" OnClick="Button2_Click" />
        </h5>
    </div>
</asp:Content>
