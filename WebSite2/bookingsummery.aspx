<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bookingsummery.aspx.cs" Inherits="EliteAir.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

  
    <h3 class="mark">
        <br />
        Summery &amp; Payment </h3>
    <p>
        Outbound</p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="28px" Width="483px"></asp:ListBox>
    </p>
    <p>
        Flight Inbound Flight</p>
    <p>
        <asp:ListBox ID="ListBox2" runat="server" Height="28px" Width="483px"></asp:ListBox>
    </p>
    <p>
    </p>
        <div style="width: 250px">

            Passenger Details
            <br />
            Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            FirstName<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            LastName
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            DOB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Nationality&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            PassportNo<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

        </div>
        <div id=" " style="position: relative; left: 259px; margin-top: -163px; top: -15px; width: 369px;">&nbsp;Payment Details
            <br />
            Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            FirstName
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            LastName<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            Postcode&nbsp;
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            CardNo&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            <br />
            Expiry Date
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            <br />
            CVSNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>

        </div>
        <div>

            Total
            <asp:Label ID="lblTotalcos" runat="server"></asp:Label>
&nbsp;
            <asp:Button ID="Button2" runat="server" Height="24px" OnClick="Button2_Click" Text="Purchase Flights" Width="173px" />

        </div>
      </div>
</asp:Content>
