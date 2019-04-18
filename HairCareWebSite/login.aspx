﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
<title>CSS Template</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
* {
  box-sizing: border-box;
}

body {
  font-family: Arial, Helvetica, sans-serif;
}

/* Style the header */
header {
  background-color: hotpink;
  padding: 30px;
  text-align: center;
  font-size: 35px;
  color: white;
}

/* Container for flexboxes */
section {
  display: -webkit-flex;
  display: flex;
}

/* Style the navigation menu */
nav {
  -webkit-flex: 1;
  -ms-flex: 1;
  flex: 1;
  background: pink;
  padding: 20px;
}

/* Style the list inside the menu */
nav ul {
  list-style-type: none;
  padding: 0;
}

/* Style the content */
article {
  -webkit-flex: 3;
  -ms-flex: 3;
  flex: 3;
  background-color: #f1f1f1;
  padding: 10px;
}

/* Style the footer */
footer {
  background-color: pink;
  padding: 10px;
  text-align: center;
  color: white;
}

/* Responsive layout - makes the menu and the content (inside the section) sit on top of each other instead of next to each other */
@media (max-width: 600px) {
  section {
    -webkit-flex-direction: column;
    flex-direction: column;
  }
}
</style>
</head>
<body>



<header>
  <h2>CEOHAIRUK</h2>
</header>

<section>
  <nav>
    <ul>
      <li><a href="MainPage.aspx">Home</a></li>
      <li><a href="CEOGallery.aspx">CEOGallery</a></li>
      <li><a href="AppointmentPage.aspx">AppointmentPage</a></li>
      <li><a href="Login.aspx">Login</a></li>
      <li><a href="SignUp.aspx">SignUp</a></li>
    </ul>
  </nav>
  
    <div>
    Have you got an account?.<br />
        <br />
       Login in below<br />
        <br />
    
        User Name
    
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <br />
        Password
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>

