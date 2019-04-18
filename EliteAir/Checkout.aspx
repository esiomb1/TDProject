<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="EliteAir.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="nav" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form id="form1" runat="server">
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
            PassportNo<asp:TextBox ID="TextBox6" runat="server" 
                OnTextChanged="TextBox6_TextChanged"></asp:TextBox>

        </div>
        <div id=" " style="position: relative; left: 259px; margin-top: -163px; top: -15px; width: 369px;">&nbsp;Payment Details
            <br />
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
            <br />
            <br />
            <br />
            <asp:Button ID="btnCB" runat="server" OnClick="btnCB_Click" 
                Text="Confirm Booking" Width="134px" />
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cancel" />

    </form>
</asp:Content>
