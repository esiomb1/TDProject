<%@ Page Title="" Language="C#" MasterPageFile="~/Just4Views.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <p> 
        Enter Your Details&nbsp; Below 
    </p> 
  
  <p>   Email <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  </p>
   
    
         Pasword 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
    
     <br />
    <br />
        <asp:Button ID="btnlogin" runat="server" Text="Log In " OnClick="login_Click" /> 
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="Cancel_Click" /> 
      


</asp:Content>

