<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="crudAplicacionWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!--BANER A CONTINUACION-->
    <br />
     <div class="row green darken-4">
         <div class="col">
           <img src="bannerCcombi.jpg" class="img-fluid" alt="Responsive image"/>
         </div>
     </div>
    <hr class=" green"/>
    <!--Formulario-->
        <!--Tarjeta-->
        <div class="container">
            <div class="card">
              <h3 class="card-header green">INGRESO AL SISTEMA</h3>
              <div class="card-body">
                <h5 class="card-title">Usuario y contraseña</h5>
                <p class="card-text">Mantenimiento de datos de mecanicos</p>
              
            <i class="material-icons prefix">person</i>
            <asp:Label ID="Label2" runat="server" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" PlaceHolder="Ingrese su nombre de usuario"></asp:TextBox>

            <i class="material-icons prefix">vpn_key</i>
            <asp:Label ID="Label3" runat="server" Text="Contraseña:" ></asp:Label>
            <asp:TextBox ID="txtContra" CssClass="form-control" runat="server" PlaceHolder="Ingrese su contraseña"></asp:TextBox><br />
            
            <div>
            <asp:Button ID="btnAceptar" class="waves-effect green btn" runat="server" Text="INGRESAR" OnClick="btnAceptar_Click" />
            </div>
            <br />
            <div class="alert  bg-success text-black"  role="alert">
                <asp:Label ID="lblMensaje" runat="server" Font-Bold="true" Text="Label">Variables de sesión: Login</asp:Label>    
            </div>
          </div>
        </div>
      </div>
</asp:Content>
