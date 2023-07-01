<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidores.aspx.cs" Inherits="MedidorASP.IngresarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h3>Ingresar Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                       <label for="NumSerie">N° de Serie: </label>
                        <asp:TextBox ID="NumSerie" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       <label for="Tipo">Tipo: </label>
                        <asp:TextBox ID="Tipo" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="btnAgregarMedidor" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgregarMedidor_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
