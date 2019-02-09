<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewFlight.aspx.cs" Inherits="EliteAir.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    
    <div style="background-color: #66FFFF; margin-top: 74px;">

 
 <div>
    
    <div class="container">
      <h1>Add a Flight </h1>
      <p>Please fill in this form to add a flight into the system </p>
        FlightNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Departure Airport &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Destination Airport <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Departure Time &nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Duration&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Cost&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Quantity <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;<div class="clearfix" style="height: 32px">
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <asp:Button ID="btnconfirm" runat="server" OnClick="btnconfirm_Click" Text="Confirm" />
      </div>
    </div>
 
</div>
        </div>
</asp:Content>
