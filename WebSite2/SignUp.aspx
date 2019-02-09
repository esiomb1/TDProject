<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="EliteAir.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    
    <div style="background-color: #66FFFF">

 
 <div>
    
    <div class="container">
      <h1>Sign Up</h1>
      <p>Please fill in this form to create an account.</p>
        Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        LastName<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Address&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Postcode <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Mobile&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
      <label for="email"><b>Email</b></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="text" placeholder="Enter Email" name="email" required>

      <label for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="psw" required>
        <br />
        <br />
&nbsp;<p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

      <div class="clearfix" style="height: 32px">
          <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" />
          <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="SignUp" />
      </div>
    </div>
 
</div>
        </div>
</asp:Content>
