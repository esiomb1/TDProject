<%@ Page Title="" Language="C#" MasterPageFile="~/Just4Views.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
   
    <div class="outer">
</div>
        <div class="inner">
    <img src="Images/black%20panther.jpg" style="height: 446px" />
            <br />
           <asp:Label ID="lblCinema" runat="server" Text="I want to go to" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:DropDownList ID="ddlCinema" runat="server" style="z-index: 1; " OnSelectedIndexChanged="ddlCinema_SelectedIndexChanged" Width="189px">
             <asp:ListItem Enabled="true" Selected="True" Text="Please select one Cinema"></asp:ListItem></asp:DropDownList>
            <br />
            <br />
           <asp:Label ID="lblMovie" runat="server" Text="to see" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:DropDownList ID="ddlMovie" runat="server" style="z-index: 1; " OnSelectedIndexChanged="ddlMovie_SelectedIndexChanged" Width="186px">
           <asp:ListItem Enabled="true" Selected="True" Text="Please select one Movie"></asp:ListItem></asp:DropDownList>
            <br />
            <br />
           <asp:Label ID="lblDate" runat="server" Text="on" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:DropDownList ID="ddlDate" runat="server" style="z-index: 1; " OnSelectedIndexChanged="ddlDate_SelectedIndexChanged" Width="187px">
            <asp:ListItem Enabled="true" Selected="True" Text="Please select one day"></asp:ListItem></asp:DropDownList>
            <br />
             <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="67px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; margin-left: 10px;" Text="Cancel" height="26px" width="72px" OnClick="btnCancel_Click" />

           
</div>
    
        
</asp:Content>
