<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="Unidad2.Datos" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
    <asp:Label ID="Label1" runat="server" Text="Numero de control:"></asp:Label>
    <asp:TextBox ID="txtNoControl" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:DropDownList ID="cmboCarreras" runat="server">
        <asp:ListItem>Sistemas</asp:ListItem>
        <asp:ListItem>Industrial</asp:ListItem>
        <asp:ListItem>Electronica</asp:ListItem>
        <asp:ListItem>Mecatronica</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        
    <asp:Label ID="lblNoControl" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="dgalumnos" runat="server"></asp:GridView>
        
</asp:Content>
