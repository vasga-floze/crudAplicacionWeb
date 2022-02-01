<%@ Page Title="Cerrar Sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="crudAplicacionWeb.CerrarSesion" %>
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
              <h3 class="card-header green">¡Esta a punto de cerrar sesión!</h3>
              <div class="card-body">
                <br />
                 <h5 class="card-title">¿Esta seguro que desea cerrar sesión?</h5>
                 <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" class="waves-effect green btn" OnClick="btnCerrarSesion_Click" />
              </div>
            </div>
         </div>
</asp:Content>
