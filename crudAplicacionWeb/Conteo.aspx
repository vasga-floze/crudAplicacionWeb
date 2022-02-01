<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Conteo.aspx.cs" Inherits="crudAplicacionWeb.Conteo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txConteo" runat="server"></asp:TextBox>
    <asp:Button ID="btIncremento" runat="server" Text="Incremento" OnClick="btIncremento_Click" />
    <asp:Label ID="Label1" runat="server" Text="Label">Variables de sesión WebForm03</asp:Label>
</asp:Content>
