<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="EliteAir.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-md-4">
            <h2>Add New Flight </h2>
            <p>click below to add a new flight </p>
            <p>
                <asp:Button ID="btnNewFlight" runat="server" Height="33px" Text="Go" Width="135px" OnClick="Button4_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Search For Flight </h2>
            <p>
                click below to see the flights schedualed by Elite air</p>
            <p>
                <asp:Button ID="btnSearch" runat="server" Height="27px" Text="Go" Width="124px" />
            </p>
        </div>
         </div>
</asp:Content>
