<%@ Page Title="Mecanicos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mecanicos.aspx.cs" Inherits="crudAplicacionWeb.Mecanicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--BANER A CONTINUACION-->
    <br />
     <div class="row green darken-4">
         <div class="col">
           <img src="bannerCcombi.jpg" class="img-fluid" alt="Responsive image"/>
         </div>
     </div>
    <hr class=" green"/>
    <!--Tarjeta-->
        <div class="container">
            <div class="card">
              <h3 class="card-header green">Sistema de Gestión de Taller Mecanico</h3>
              <div class="card-body">
                <h5 class="card-title">MECANICOS</h5>
                <p class="card-text">Mantenimiento de datos de mecanicos</p>
                 <h3>Bienvenido!</h3>
              </div>
            </div>
         </div>
      <i class="material-icons prefix">vpn_key</i>
      <asp:Label ID="lblCodigo" runat="server" Text="Label">Código:</asp:Label>         
      <asp:TextBox ID="txtCodigo" CssClass="form-control"  runat="server"></asp:TextBox>

      <i class="material-icons prefix">person</i>
      <asp:Label ID="Label2" runat="server" Text="Label">Nombre:</asp:Label>         
      <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>

      <i class="material-icons prefix">directions</i>
      <asp:Label ID="Label4" runat="server" Text="Label">Dirección:</asp:Label>         
      <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>

      <i class="material-icons prefix">phone</i>
      <asp:Label ID="Label3" runat="server" Text="Label">Teléfono:</asp:Label>         
      <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>

      <i class="material-icons prefix">monetization_on</i>
      <asp:Label ID="Label5" runat="server" Text="Label">Costo/Hora:</asp:Label>         
      <asp:TextBox ID="txtCostoHora" CssClass="form-control" runat="server"></asp:TextBox><hr class=" green " />

      <asp:Button ID="btnNuevo" class="waves-effect green btn" runat="server"  Text="NUEVO" OnClick="btnNuevo_Click" />
      <asp:Button ID="btnGuardar" class="waves-effect green btn" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click"/>
      <asp:Button ID="btnModificar" class="waves-effect green btn" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click"/>
      <asp:Button ID="btnConsultar" class="waves-effect green btn" runat="server" Text="CONSULTAR" OnClick="btnConsultar_Click" />
      <asp:Button ID="btnEliminar" class="waves-effect green btn" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click" />
     <hr class=" green"/>
     <asp:Label ID="lblMensajeNotificador"  runat="server" Text="- - - - - - - - - - -"></asp:Label>

</asp:Content>
