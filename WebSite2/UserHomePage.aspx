<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="EliteAir.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    <br />

    <br />
    <br />

</div>




    <div class="jumbotron">
        <h1>Search For Flights </h1>
        <p class="lead">Departure Airport&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Destination Airport&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="btnReturn" runat="server" Text="Return " />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>Departure Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return Date </p>
      <div id="date1"> 
    <asp:Calendar ID="Calendar4" runat="server"></asp:Calendar>
</div>
<div id="date2" style="position: relative; left: 300px; margin-top: -163px;">
 <asp:Calendar ID="Calendar6" runat="server"></asp:Calendar>
</div>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="48px" Text="Search" Width="135px" OnClick="Button2_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Elite Air Account </h2>
            <p>
                click below to view Your Booked Flights
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="Button3" runat="server" Height="27px" Text="View Bookings " Width="124px" OnClick="Button3_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Who are we ?</h2>
            <p>
                Elite Air is your go to airline for flight deals and last minute flights. were a team of passionate ,savvy traveller on a mission to make it easier for you to findthhe best flight deals.
                Elite air is the starting Point for Your Travel Planing
            </p>
         
        </div>

    </div>

</asp:Content>
