<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css" runat="server">
        .img {
    position: relative;
    
}

.btnMen {
    border-style: none;
    border-width: medium;
    position: absolute;
    bottom: 250px;
    left: 17%;
    -ms-transform: translate(-50%, -50%);
    -moz-transform: translate(-50%, -50%);
    -webkit-transform: translate(-50%, -50%);
    -o-transform: translate(-50%, -50%);
    transform: translate(-50%, -50%);
    background-color: white;
    color: black;
    font-size: 16px;
    padding: 16px 30px;
    cursor: pointer;
    border-radius: 5px;
    text-align: center;
    height: 68px;
    width: 227px;
}

.btnWomen {
    border-style: none;
    border-width: medium;
    width: 200px;
    position: absolute;
    bottom: 250px;
    right: 30%;
    -ms-transform: translate(-50%, -50%);
    -moz-transform: translate(-50%, -50%);
    -webkit-transform: translate(-50%, -50%);
    -o-transform: translate(-50%, -50%);
    transform: translate(-50%, -50%);
    background-color: white;
    color: black;
    font-size: 16px;
    padding: 16px 30px;
    cursor: pointer;
    border-radius: 5px;
    text-align: center;
}



    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <section class="home">
    
     <div class="mens fashion">
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="btnMensFashion" CssClass="btnMen" runat="server" Text="Men" OnClick="btnMensFashion_Click1" />
     <img src="images/mens-fashion.jpg" alt="mens fashion" height="700" width:"594px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnWomenFashion" CssClass="btnWomen" runat="server" Text="Women" />
     <img src="images/Womens-Fashion.jpg" alt="womens fashion" width:"600px" style="height: 678px"  />
     
    </div>
    </section>
</asp:Content>

    
    