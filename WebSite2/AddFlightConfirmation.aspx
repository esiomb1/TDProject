<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFlightConfirmation.aspx.cs" Inherits="EliteAir.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div style="background-color: #66FFFF; margin-top: 66px;">

 
 <div>
    
    <div class="container">
      <h1>Flight has sussesfully been added </h1>
      <p>details below </p>
        FlightNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblFlightNo" runat="server"></asp:Label>
        <br />
        Departure Airport &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="lblDA" runat="server"></asp:Label>
        <br />
        Destination Airport 
        <asp:Label ID="lblDDA" runat="server"></asp:Label>
        <br />
        Departure Time &nbsp;
        <asp:Label ID="lbltime" runat="server"></asp:Label>
        <br />
        Duration&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbldu" runat="server"></asp:Label>
        <br />
        Cost&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblcost" runat="server"></asp:Label>
        <br />
        Quantity&nbsp;&nbsp;&nbsp; <asp:Label ID="lblqu" runat="server"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;<div class="clearfix" style="height: 148px">
            <asp:Button ID="btnConfirm" runat="server" OnClick="Button2_Click" Text="Done" />
      </div>
    </div>
 
</div>
        </div>
</asp:Content>
