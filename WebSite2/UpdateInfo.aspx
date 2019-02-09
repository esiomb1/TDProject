<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="EliteAir.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <div style="background-color: #66FFFF; margin-top: 115px;">

 
 <div>
    
    <div class="container">
      <h1>Update Personal Details </h1>
      <p>&nbsp;</p>
        <br />
        Address&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Postcode <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Mobile&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Old Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="text" placeholder="Enter Email" name="email" required>

      <label for="psw"><b>
        <br />
        </b></label>
        <br />
        New Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="text" placeholder="Enter Email" name="email0" required><br />
&nbsp;<div class="clearfix" style="height: 32px">
            <asp:Button ID="btncancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnsave" runat="server" Text="Save" Width="79px" />
      </div>
    </div>
 
</div>
        </div>
</asp:Content>
