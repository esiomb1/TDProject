<%@ Page Title="" Language="C#" MasterPageFile="~/Just4Views.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
            <asp:Label ID="lblMovieId" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this Movie?"></asp:Label>
                <br />
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" height="26px" style="z-index: 1;" Text="No" width="59px" OnClick="btnNo_Click" />
</asp:Content>

