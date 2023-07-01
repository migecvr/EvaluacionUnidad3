<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidorASP.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">

                    <div class="form-group">
                       <label for="medidorDdl">Medidor: </label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control form-select"></asp:DropDownList>
                    </div>

                     <div class="form-group">
                       <label for="FechaTxt">Fecha: </label>
                        <asp:TextBox ID="FechaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       <label for="HoraTxt">Hora: </label>
                        <asp:TextBox ID="HoraTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                     <div class="form-group">
                       <label for="MinutoTxt">Minuto: </label>
                        <asp:TextBox ID="MinutoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <div class="form-group">
                       <label for="ConsumoTxt">Consumo: </label>
                        <asp:TextBox ID="ConsumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>




                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="btnIngresarLectura" Text="Ingresar" CssClass="btn btn-primary mt-2" OnClick="btnIngresarLectura_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
