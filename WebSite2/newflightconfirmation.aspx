<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newflightconfirmation.aspx.cs" Inherits="EliteAir.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
    <div style="height: 460px; margin-top: 100px;">

        <h2>New Flight Confirmation </h2>
        <p>
            Flight&nbsp;&nbsp; <asp:Label ID="lblPassenger" runat="server"></asp:Label>
        </p>
        <p>
            Departure Airport
            <asp:Label ID="lblda" runat="server"></asp:Label>
        </p>
        <p>
            Destination
            <asp:Label ID="lblDestination" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="lblda0" runat="server"></asp:Label>
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
         
         <h5> Your Flight Has Been Added&nbsp; Succsefully  <asp:Button ID="Button2" runat="server" Height="32px" Text="Home Page " Width="205px" OnClick="Button2_Click" />
        </h5>
    </div>
           </div>
</asp:Content>
