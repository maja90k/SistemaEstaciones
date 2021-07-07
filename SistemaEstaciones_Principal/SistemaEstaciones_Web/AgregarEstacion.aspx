<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="SistemaEstaciones_Web.AgregarEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="card">
        <div class="card-header bg-dark text-white">
            Ingresar nueva Estacion de servicio
        </div>
        <div class="card-body">
            <div class="form-group">
                <label for="idEstacionNumb">Id de estacion:</label>    
                <asp:TextBox ID="idEstacionNumb" runat="server" CssClass="form-control"></asp:TextBox>               
            </div> 
            <div class="form-group">
                <label for="DireccionTxt">Direccion</label>
                <asp:TextBox ID="DireccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           <!--Capacidad -->
           <!--HorarioAtencion -->
        </div>
        <asp:Button ID="ingresarBtn" runat="server" Text="Ingresar Estacion" CssClass="btn btn-primary" OnClick="ingresarBtn_Click"/>
    </div>
</asp:Content>
