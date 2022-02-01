<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="crudAplicacionWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="jumbotron  green">
   <div class="green darken-4">
       <!--BANER A CONTINUACION-->
            <div class="row">
                <div class="col">
                    <img src="bannerCcombi.jpg" class="img-fluid" alt="Responsive image"/>
                </div>
            </div>
       <!--Mensaje de Inicio de Sesión-->
       <hr />
       <i class="material-icons prefix">person</i>
       <asp:Label ID="lblSesion" Class="flow-text text-white" runat="server" Text="Inicie sesión"></asp:Label>
       <hr />
       <!--Fin del mensaje de incio de sesion-->

    <div class="jumbotron">
        <h1>CRUD BASICO</h1>
        <h2>Integrantes del equipo:</h2>

         <div class="row">
        <div class="col-md-3">
            <h3>Vasti Flores</h3>
            <img src="Vasti.jpg" alt="..." class="img-thumbnail" />
            <div class="card-footer text-muted">
                <p>SMIS003119</p> 
            </div>
        </div>
        <div class="col-md-3">
        <h3>Kilmar Chevez</h3>
            <img src="Kilmar.jpg" alt="..." class="img-thumbnail" />
               <div class="card-footer text-muted">
                <p>SMIS619019</p> 
            </div>
        </div>
        <div class="col-md-3">
            <h3>Bryam Diaz</h3>
            <img src="Bryam.jpg" alt="..." class="img-thumbnail"/>
            <div class="card-footer text-muted">
                <p>SMIS041119</p> 
            </div>
        </div>
        <div class="col-md-3">
            <h3>Nelson Chavez</h3>
            <img src="avatarNelson.png" alt="..." class="img-thumbnail" />
            <div class="card-footer text-muted">
                <p>SMIS052119</p> 
            </div>
        </div>
    </div>
    </div>
</div> 
</div>
</asp:Content>
