<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="crudAplicacionWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <!--BANER A CONTINUACION-->
     <div class="row green darken-4">
         <div class="col">
           <img src="bannerCcombi.jpg" class="img-fluid" alt="Responsive image"/>
         </div>
     </div>
    <hr class=" green"/>
    <div class="jumbotron row green">
    <div class="green">
            <h2>NUESTROS SERVICIOS</h2>
            <h4>Somos un taller mecánico con más de dos décadas de experiencia a nuestras espaldas, 
                mecánicos profesionales y maquinaria de última generación.</h4>

            <div class="row row-cols-1 row-cols-md-2">
          <div class="col mb-3">
            <div class="card">
                <img src="serviciosUno.jpeg" class="img-thumbnail" alt="..."/>
              <div class="card-body">
                <h5 class="card-title">Mantenimiento General</h5>
                 </div>
            </div>
          </div>

          <div class="col mb-3">
            <div class="card">
                <img src="serviciosDos.jpeg" class="img-thumbnail" alt="..."/>
              <div class="card-body">
                <h5 class="card-title">Mantenimiento General</h5>
                 </div>
            </div>
          </div>

          <div class="col mb-3">
            <div class="card">
                <img src="serviciosTres.jpeg" class="img-thumbnail" alt="..."/>
              <div class="card-body">
                <h5 class="card-title">Enderezado y pintura</h5>
                 </div>
            </div>
          </div>

          <div class="col mb-3">
            <div class="card">
                <img src="serviciosCuatro.jpeg" class="img-thumbnail" alt="..."/>
              <div class="card-body">
                <h5 class="card-title">Cerrajeria Automotriz</h5>
                </div>
            </div>
          </div>
        </div>
     </div>
    </div>
</asp:Content>
