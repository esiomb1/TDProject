<%@ Page Title="" Language="C#" MasterPageFile="~/ClothingProject2.master" AutoEventWireup="true" CodeFile="Place Order.aspx.cs" Inherits="Place_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
       body {
  font-family: Arial;
  font-size: 17px;
  padding: 8px;
}

* {
  box-sizing: border-box;
}

.row {
  display: -ms-flexbox; /* IE10 */
  display: flex;
  -ms-flex-wrap: wrap; /* IE10 */
  flex-wrap: wrap;
  margin: 0 -16px;
}

.col-25 {
  -ms-flex: 25%; /* IE10 */
  flex: 25%;
}

.col-50 {
  -ms-flex: 50%; /* IE10 */
  flex: 50%;
}

.col-75 {
  -ms-flex: 75%; /* IE10 */
  flex: 75%;
}

.col-25,
.col-50,
.col-75 {
  padding: 0 16px;
}

.container {
  background-color: #f2f2f2;
  padding: 5px 20px 15px 20px;
  border: 1px solid lightgrey;
  border-radius: 3px;
}

input[type=text] {
  width: 100%;
  margin-bottom: 20px;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 3px;
}

label {
  margin-bottom: 10px;
  display: block;
}

.icon-container {
  margin-bottom: 20px;
  padding: 7px 0;
  font-size: 24px;
}

.btn {
  background-color: #4CAF50;
  color: white;
  padding: 12px;
  margin: 10px 0;
  border: none;
  width: 100%;
  border-radius: 3px;
  cursor: pointer;
  font-size: 17px;
}

.btn:hover {
  background-color: #45a049;
}

a {
  color: #2196F3;
}

hr {
  border: 1px solid lightgrey;
}



/* Responsive layout - when the screen is less than 800px wide, make the two columns stack on top of each other instead of next to each other (also change the direction - make the "cart" column go on top) */
@media (max-width: 800px) {
  .row {
    flex-direction: column-reverse;
  }
  .col-25 {
    margin-bottom: 20px;
  }
}
        .auto-style21 {
            width: 106px;
            height: 83px;
        }
        .auto-style22 {
            width: 115px;
            height: 64px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="row">
  <div class="col-75">
    <div class="container">
      <form action="/action_page.php">
      
        <div class="row">
          <div class="col-50">
            <p>Order Id&nbsp; 
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
              </p>
              <p>Order date
                  <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
              </p>
              <h3>Billing Address</h3>
              <i class="fa fa-user"></i> Full Name
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <br />
              &nbsp;
            <i class="fa fa-address-card-o"></i> Address
              <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          </div>

          <div class="col-50">
            <h3>Payment</h3>
            <label for="fname">Accepted Cards</label>
            <div class="icon-container">
              <i class="fa fa-cc-visa" style="color:navy;"></i>
              <i class="fa fa-cc-amex" style="color:blue;"></i>
              <i class="fa fa-cc-mastercard" style="color:red;"></i>
              <i class="fa fa-cc-discover" style="color:orange;"></i>
                <img alt="" class="auto-style21" src="images/kisspng-visa-logo-mastercard-credit-card-payment-5b15b13e347986.454908321528148286215.jpg" /><img alt="" class="auto-style22" src="images/American-Express-copy.png" /></div>
              Name on Card
              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              <br />
              Credit card number
              <br />
              <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<div class="row">
              <div class="col-50">
                  Exp Year
                  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                  <br />
&nbsp;</div>
              <div class="col-50">
                &nbsp;</div>
            </div>
          </div>
          
        </div>
        <label>
          <input type="checkbox" checked="checked" name="sameadr"> Shipping address same as billing
          <br />
        </label>
          <br />
          Order<br />
          <br />


        <asp:Button ID="btnPlaceOrder" runat="server" Height="46px" Text="PlaceOrder" Width="216px" OnClick="btnPlaceOrder_Click" />


          <br />


        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="139px" Width="1359px">
            <Columns>
                <asp:BoundField DataField="ProductId" HeaderText="ProductId"></asp:BoundField>
                <asp:BoundField DataField="Description" HeaderText="Descripiton"></asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Price"></asp:BoundField>
                <asp:BoundField DataField="ProductType" HeaderText="ProductType"></asp:BoundField>
                <asp:BoundField DataField="ProductImage" HeaderText="ProductImage"></asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <sortedascendingcellstyle backcolor="#FFF1D4" />
            <sortedascendingheaderstyle backcolor="#B95C30" />
            <sorteddescendingcellstyle backcolor="#F1E5CE" />
            <sorteddescendingheaderstyle backcolor="#93451F" />
        </asp:GridView>



</asp:Content>

