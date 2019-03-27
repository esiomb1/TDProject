<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="schedualedfligts.aspx.cs" Inherits="schedualedfligts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ListBox ID="lstsch" runat="server" Height="242px" OnSelectedIndexChanged="lstsch_SelectedIndexChanged" Width="1202px"></asp:ListBox>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TDDBConnectionString %>" SelectCommand="SELECT [DepartureAirport], [DestinationAirport], [DepartureTime], [ArrivalTime], [Duration], [FlightNo], [Cost] FROM [tblFlights]"></asp:SqlDataSource>
</asp:Content>

