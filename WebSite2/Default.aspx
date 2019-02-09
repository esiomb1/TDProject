<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EliteAir._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
    <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
</div>
<div id="date2" style="position: relative; left: 300px; margin-top: -163px;">
    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
</div>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="48px" Text="Search" Width="135px" OnClick="Button2_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2><span style="color: rgb(23, 35, 44); font-family: &quot;Gibson SemiBold&quot;, Tahoma, Helvetica, sans-serif; font-size: 26px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: #CCFFFF; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Top destinations</span></h2>
            <p>
                <span style="color: rgb(85, 89, 100); font-family: &quot;Gibson Regular&quot;, Tahoma, Helvetica, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: #CCFFFF; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Find the best price on flights to our most popular destinations from airports across UK &amp; Ireland </span>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Elite Air Account </h2>
            <p>
                Log in to see your current flights and to book some more
            </p>
            <p>
                Dont Have an account with us ? Sign Up Bellow
            </p>
            <p>
                <asp:Button ID="Button3" runat="server" Height="27px" Text="Sign Up" Width="124px" OnClick="Button3_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Who are we ?</h2>
            <p>
                Elite Air is your go to airline for flight deals and last minute flights. were a team of passionate ,savvy traveller on a mission to make it easier for you to find the best flight deals.
            </p>
        </div>

    </div>

</asp:Content>
