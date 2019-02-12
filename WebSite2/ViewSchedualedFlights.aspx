<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="EliteAir.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <h2>&nbsp;Schedualed Flights By Elite Air&nbsp; </h2>
        </div>
        <div class="col-md-4">
            <asp:ListBox ID="lbFlights" runat="server" Height="256px" Width="332px"></asp:ListBox>
            <br />
            <br />
            <br />
        </div>
         </div>
</asp:Content>
